﻿#region using directives

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using GeoCoordinatePortable;
using Cv3PKM.Bot.Logic.Utils;
using Cv3PKM.RocketAPI;
using Cv3PKM.Protos.Networking.Responses;
using Cv3PKM.Bot.Logic.State;
using Cv3PKM.Bot.Logic.Event;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;

#endregion

namespace Cv3PKM.Bot.Logic
{
    public delegate void UpdatePositionDelegate(double lat, double lng);

    public class Navigation
    {
        private double CurrentWalkingSpeed;
        private DateTime LastMajorVariantWalkingSpeed;
        private DateTime NextMajorVariantWalkingSpeed;
        private Random randWalking = new Random();

        private const double SpeedDownTo = 10 / 3.6;
        private readonly Client _client;

        public Navigation(Client client)
        {
            _client = client;
        }

        private double MajorWalkingSpeedVariant(ISession session)
        {
            if (LastMajorVariantWalkingSpeed == DateTime.MinValue && NextMajorVariantWalkingSpeed == DateTime.MinValue)
            {
                var minutes = randWalking.NextDouble() * (2 - 6) + 2;
                LastMajorVariantWalkingSpeed = DateTime.Now;
                NextMajorVariantWalkingSpeed = LastMajorVariantWalkingSpeed.AddMinutes(minutes);
                CurrentWalkingSpeed = session.LogicSettings.WalkingSpeedInKilometerPerHour;
            }
            else if (NextMajorVariantWalkingSpeed.Ticks < DateTime.Now.Ticks)
            {
                var oldWalkingSpeed = CurrentWalkingSpeed;

                var randomMin = session.LogicSettings.WalkingSpeedInKilometerPerHour - session.LogicSettings.WalkingSpeedVariant;
                var randomMax = session.LogicSettings.WalkingSpeedInKilometerPerHour + session.LogicSettings.WalkingSpeedVariant;
                CurrentWalkingSpeed = randWalking.NextDouble() * (randomMax - randomMin) + randomMin;

                var minutes = randWalking.NextDouble() * (2 - 6) + 2;
                LastMajorVariantWalkingSpeed = DateTime.Now;
                NextMajorVariantWalkingSpeed = LastMajorVariantWalkingSpeed.AddMinutes(minutes);

                session.EventDispatcher.Send(new HumanWalkingEvent
                {
                    OldWalkingSpeed = oldWalkingSpeed,
                    CurrentWalkingSpeed = CurrentWalkingSpeed
                });
            }

            return CurrentWalkingSpeed / 3.6;
        }

        private double MinorWalkingSpeedVariant(ISession session)
        {
            if (randWalking.Next(1, 10) > 5) //Random change or no variant speed
            {
                var oldWalkingSpeed = CurrentWalkingSpeed;

                if (randWalking.Next(1, 10) > 5) //Random change upper or lower variant speed
                {
                    var randomMax = session.LogicSettings.WalkingSpeedInKilometerPerHour + session.LogicSettings.WalkingSpeedVariant + 0.5;

                    CurrentWalkingSpeed += randWalking.NextDouble() * (0.01 - 0.09) + 0.01;
                    if (CurrentWalkingSpeed > randomMax)
                        CurrentWalkingSpeed = randomMax;
                }
                else
                {
                    var randomMin = session.LogicSettings.WalkingSpeedInKilometerPerHour - session.LogicSettings.WalkingSpeedVariant - 0.5;

                    CurrentWalkingSpeed -= randWalking.NextDouble() * (0.01 - 0.09) + 0.01;
                    if (CurrentWalkingSpeed < randomMin)
                        CurrentWalkingSpeed = randomMin;
                }

                if (oldWalkingSpeed != CurrentWalkingSpeed)
                {
                    session.EventDispatcher.Send(new HumanWalkingEvent
                    {
                        OldWalkingSpeed = oldWalkingSpeed,
                        CurrentWalkingSpeed = CurrentWalkingSpeed
                    });
                }
            }

            return CurrentWalkingSpeed / 3.6;
        }
        
        private List<List<double>> Route(ISession session, GeoCoordinate start, GeoCoordinate dest)
        {
            List<List<double>> result = new List<List<double>>();
            
            try
            {
                WebRequest web = WebRequest.Create(
                    $"https://maps.googleapis.com/maps/api/directions/json?origin={start.Latitude},{start.Longitude}&destination={dest.Latitude},{dest.Longitude}&mode=walking&units=metric&key={session.LogicSettings.GoogleAPIKey}");
                web.Credentials = CredentialCache.DefaultCredentials;

                string strResponse = string.Empty;
                using (WebResponse response = web.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                            strResponse = reader.ReadToEnd();
                    }
                }

                JObject parseObject = JObject.Parse(strResponse);
                result = Points(parseObject["routes"][0]["overview_polyline"]["points"].ToString(), 1e5);
            }
            catch (WebException e)
            {
                session.EventDispatcher.Send(new WarnEvent
                {
                    Message = $"Web Exception: {e.Message}"
                });
            }
            catch (NullReferenceException e)
            {
                session.EventDispatcher.Send(new WarnEvent
                {
                    Message = $"Routing Error: {e.Message}"
                });
            }

            return result;
        }

        public static List<List<double>> Points(string overview, double precision)
        {
            if (string.IsNullOrEmpty(overview))
                throw new ArgumentNullException("Points");
            
            bool polyline = false;
            int index = 0, lat = 0, lng = 0;
            char[] polylineChars = overview.ToCharArray();
            List<List<double>> result = new List<List<double>>();

            while (index < polylineChars.Length)
            {
                int sum = 0, shifter = 0, nextBits;
                List<double> coordinates = new List<double>();

                do
                {
                    nextBits = polylineChars[index++] - 63;
                    sum |= (nextBits & 0x1f) << shifter;
                    shifter += 5;
                } while (nextBits >= 0x20 && index < polylineChars.Length);

                if (index >= polylineChars.Length && (!polyline || nextBits >= 0x20))
                    break;

                if (!polyline)
                    lat += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);
                else
                {
                    lng += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);
                    coordinates.Add(lng / precision);
                    coordinates.Add(lat / precision);
                    result.Add(coordinates);
                }

                polyline = !polyline;
            }

            return result;
        }

        public async Task<PlayerUpdateResponse> Move(GeoCoordinate targetLocation, Func<Task<bool>> functionExecutedWhileWalking,
            ISession session,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (!session.LogicSettings.DisableHumanWalking)
            {
                PlayerUpdateResponse result = null;
                List<GeoCoordinate> points = new List<GeoCoordinate>();
                var route = Route(session,
                    new GeoCoordinate(
                        _client.CurrentLatitude,
                        _client.CurrentLongitude,
                        _client.CurrentAltitude),
                    targetLocation);

                foreach (var item in route)
                    points.Add(new GeoCoordinate(item.ToArray()[1], item.ToArray()[0]));

                for (int i = 0; i < points.Count; i++)
                {
                    var speedInMetersPerSecond = session.LogicSettings.UseWalkingSpeedVariant ? MajorWalkingSpeedVariant(session) :
                    session.LogicSettings.WalkingSpeedInKilometerPerHour / 3.6;
                    var sourceLocation = new GeoCoordinate(_client.CurrentLatitude, _client.CurrentLongitude);

                    var nextWaypointBearing = LocationUtils.DegreeBearing(sourceLocation, points.ToArray()[i]);
                    var nextWaypointDistance = speedInMetersPerSecond;
                    var waypoint = LocationUtils.CreateWaypoint(sourceLocation, nextWaypointDistance, nextWaypointBearing);

                    var requestSendDateTime = DateTime.Now;
                    result =
                        await
                            _client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude,
                                waypoint.Altitude);

                    UpdatePositionEvent?.Invoke(waypoint.Latitude, waypoint.Longitude);

                    var realDistanceToTarget = LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation);
                    if (realDistanceToTarget < 30)
                        break;

                    do
                    {
                        cancellationToken.ThrowIfCancellationRequested();

                        var millisecondsUntilGetUpdatePlayerLocationResponse =
                            (DateTime.Now - requestSendDateTime).TotalMilliseconds;

                        sourceLocation = new GeoCoordinate(_client.CurrentLatitude, _client.CurrentLongitude);
                        var currentDistanceToTarget = LocationUtils.CalculateDistanceInMeters(sourceLocation, points.ToArray()[i]);

                        var realDistanceToTargetSpeedDown = LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation);
                        if (realDistanceToTargetSpeedDown < 40)
                            if (speedInMetersPerSecond > SpeedDownTo)
                                speedInMetersPerSecond = SpeedDownTo;

                        if (session.LogicSettings.UseWalkingSpeedVariant)
                            speedInMetersPerSecond = MinorWalkingSpeedVariant(session);

                        nextWaypointDistance = Math.Min(currentDistanceToTarget,
                            millisecondsUntilGetUpdatePlayerLocationResponse / 1000 * speedInMetersPerSecond);
                        nextWaypointBearing = LocationUtils.DegreeBearing(sourceLocation, points.ToArray()[i]);
                        waypoint = LocationUtils.CreateWaypoint(sourceLocation, nextWaypointDistance, nextWaypointBearing);

                        requestSendDateTime = DateTime.Now;
                        result =
                            await
                                _client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude,
                                    waypoint.Altitude);

                        UpdatePositionEvent?.Invoke(waypoint.Latitude, waypoint.Longitude);

                        if (functionExecutedWhileWalking != null)
                            await functionExecutedWhileWalking(); // look for pokemon
                    } while (LocationUtils.CalculateDistanceInMeters(sourceLocation, points.ToArray()[i]) >= 2);

                    UpdatePositionEvent?.Invoke(points.ToArray()[i].Latitude, points.ToArray()[i].Longitude);
                }

                return result;
            }

            var curLocation = new GeoCoordinate(_client.CurrentLatitude, _client.CurrentLongitude);
            var dist = LocationUtils.CalculateDistanceInMeters(curLocation, targetLocation);
            if (dist >= 100)
            {
                var nextWaypointDistance = dist * 70 / 100;
                var nextWaypointBearing = LocationUtils.DegreeBearing(curLocation, targetLocation);

                var waypoint = LocationUtils.CreateWaypoint(curLocation, nextWaypointDistance, nextWaypointBearing);
                var sentTime = DateTime.Now;

                var result =
                    await
                        _client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude,
                            waypoint.Altitude);
                UpdatePositionEvent?.Invoke(waypoint.Latitude, waypoint.Longitude);

                do
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var millisecondsUntilGetUpdatePlayerLocationResponse =
                        (DateTime.Now - sentTime).TotalMilliseconds;

                    curLocation = new GeoCoordinate(_client.CurrentLatitude, _client.CurrentLongitude);
                    var currentDistanceToTarget = LocationUtils.CalculateDistanceInMeters(curLocation, targetLocation);

                    dist = LocationUtils.CalculateDistanceInMeters(curLocation, targetLocation);

                    if (dist >= 100)
                        nextWaypointDistance = dist * 70 / 100;
                    else
                        nextWaypointDistance = dist;

                    nextWaypointBearing = LocationUtils.DegreeBearing(curLocation, targetLocation);
                    waypoint = LocationUtils.CreateWaypoint(curLocation, nextWaypointDistance, nextWaypointBearing);
                    sentTime = DateTime.Now;
                    result =
                        await
                            _client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude,
                                waypoint.Altitude);

                    UpdatePositionEvent?.Invoke(waypoint.Latitude, waypoint.Longitude);


                    if (functionExecutedWhileWalking != null)
                        await functionExecutedWhileWalking(); // look for pokemon
                } while (LocationUtils.CalculateDistanceInMeters(curLocation, targetLocation) >= 10);
                return result;
            }
            else
            {
                var result =
                    await
                        _client.Player.UpdatePlayerLocation(targetLocation.Latitude, targetLocation.Longitude,
                            LocationUtils.getElevation(targetLocation.Latitude, targetLocation.Longitude));
                UpdatePositionEvent?.Invoke(targetLocation.Latitude, targetLocation.Longitude);
                if (functionExecutedWhileWalking != null)
                    await functionExecutedWhileWalking(); // look for pokemon
                return result;
            }
        }

        public async Task<PlayerUpdateResponse> HumanPathWalking(GpxReader.Trkpt trk,
            Func<Task<bool>> functionExecutedWhileWalking,
            ISession session,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            //PlayerUpdateResponse result = null;

            var targetLocation = new GeoCoordinate(Convert.ToDouble(trk.Lat, CultureInfo.InvariantCulture),
                Convert.ToDouble(trk.Lon, CultureInfo.InvariantCulture));
            var speedInMetersPerSecond = session.LogicSettings.UseWalkingSpeedVariant ? MajorWalkingSpeedVariant(session) :
                    session.LogicSettings.WalkingSpeedInKilometerPerHour / 3.6;
            var sourceLocation = new GeoCoordinate(_client.CurrentLatitude, _client.CurrentLongitude);
            LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation);
            var nextWaypointBearing = LocationUtils.DegreeBearing(sourceLocation, targetLocation);
            var nextWaypointDistance = speedInMetersPerSecond;
            var waypoint = LocationUtils.CreateWaypoint(sourceLocation, nextWaypointDistance, nextWaypointBearing,
                Convert.ToDouble(trk.Ele, CultureInfo.InvariantCulture));
            var requestSendDateTime = DateTime.Now;
            var requestVariantDateTime = DateTime.Now;
            var result =
                await
                    _client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude, waypoint.Altitude);

            UpdatePositionEvent?.Invoke(waypoint.Latitude, waypoint.Longitude);

            do
            {
                cancellationToken.ThrowIfCancellationRequested();

                var millisecondsUntilGetUpdatePlayerLocationResponse =
                    (DateTime.Now - requestSendDateTime).TotalMilliseconds;

                sourceLocation = new GeoCoordinate(_client.CurrentLatitude, _client.CurrentLongitude);
                var currentDistanceToTarget = LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation);

                //if (currentDistanceToTarget < 40)
                //{
                //    if (speedInMetersPerSecond > SpeedDownTo)
                //    {
                //        //Logger.Write("We are within 40 meters of the target. Speeding down to 10 km/h to not pass the target.", LogLevel.Info);
                //        speedInMetersPerSecond = SpeedDownTo;
                //    }
                //}

                if (session.LogicSettings.UseWalkingSpeedVariant)
                    speedInMetersPerSecond = MinorWalkingSpeedVariant(session);

                nextWaypointDistance = Math.Min(currentDistanceToTarget,
                    millisecondsUntilGetUpdatePlayerLocationResponse / 1000 * speedInMetersPerSecond);
                nextWaypointBearing = LocationUtils.DegreeBearing(sourceLocation, targetLocation);
                waypoint = LocationUtils.CreateWaypoint(sourceLocation, nextWaypointDistance, nextWaypointBearing);

                requestSendDateTime = DateTime.Now;
                result =
                    await
                        _client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude,
                            waypoint.Altitude);

                UpdatePositionEvent?.Invoke(waypoint.Latitude, waypoint.Longitude);

                if (functionExecutedWhileWalking != null)
                    await functionExecutedWhileWalking(); // look for pokemon & hit stops
            } while (LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation) >= 30);

            return result;
        }

        public event UpdatePositionDelegate UpdatePositionEvent;
    }
}