#region using directives

using Cv3PKM.Protos.Networking.Responses;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class ProfileEvent : IEvent
    {
        public GetPlayerResponse Profile;
    }
}