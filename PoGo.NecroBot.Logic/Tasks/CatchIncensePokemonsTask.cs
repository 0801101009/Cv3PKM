#region using directives

using System.Threading;
using System.Threading.Tasks;
using Cv3PKM.Bot.Logic.Common;
using Cv3PKM.Bot.Logic.Event;
using Cv3PKM.Bot.Logic.Logging;
using Cv3PKM.Bot.Logic.State;
using Cv3PKM.Bot.Logic.Utils;
using Cv3PKM.Protos.Map.Pokemon;
using Cv3PKM.Protos.Networking.Responses;

#endregion

namespace Cv3PKM.Bot.Logic.Tasks
{
    public static class CatchIncensePokemonsTask
    {
        public static async Task Execute(ISession session, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (!session.LogicSettings.CatchPokemon) return;
            
            Logger.Write(session.Translation.GetTranslation(TranslationString.LookingForIncensePokemon), LogLevel.Debug);

            var incensePokemon = await session.Client.Map.GetIncensePokemons();
            if (incensePokemon.Result == GetIncensePokemonResponse.Types.Result.IncenseEncounterAvailable)
            {
                var pokemon = new MapPokemon
                {
                    EncounterId = incensePokemon.EncounterId,
                    ExpirationTimestampMs = incensePokemon.DisappearTimestampMs,
                    Latitude = incensePokemon.Latitude,
                    Longitude = incensePokemon.Longitude,
                    PokemonId = incensePokemon.PokemonId,
                    SpawnPointId = incensePokemon.EncounterLocation
                };

                if( ( session.LogicSettings.UsePokemonSniperFilterOnly && !session.LogicSettings.PokemonToSnipe.Pokemon.Contains( pokemon.PokemonId ) ) ||
                    ( session.LogicSettings.UsePokemonToNotCatchFilter && session.LogicSettings.PokemonsNotToCatch.Contains( pokemon.PokemonId ) ) )
                {
                    Logger.Write(session.Translation.GetTranslation(TranslationString.PokemonIgnoreFilter,
                        session.Translation.GetPokemonTranslation(pokemon.PokemonId)));
                }
                else
                {
                    var distance = LocationUtils.CalculateDistanceInMeters(session.Client.CurrentLatitude,
                        session.Client.CurrentLongitude, pokemon.Latitude, pokemon.Longitude);
                    await Task.Delay(distance > 100 ? 500 : 100, cancellationToken);

                    var encounter =
                        await
                            session.Client.Encounter.EncounterIncensePokemon((ulong) pokemon.EncounterId,
                                pokemon.SpawnPointId);

                    if (encounter.Result == IncenseEncounterResponse.Types.Result.IncenseEncounterSuccess && session.LogicSettings.CatchPokemon)
                    {
                        await CatchPokemonTask.Execute(session, cancellationToken, encounter, pokemon);
                    }
                    else if (encounter.Result == IncenseEncounterResponse.Types.Result.PokemonInventoryFull)
                    {
						if (session.LogicSettings.TransferDuplicatePokemon || session.LogicSettings.TransferWeakPokemon)
						{
							session.EventDispatcher.Send(new WarnEvent
							{
								Message = session.Translation.GetTranslation(TranslationString.InvFullTransferring)
							});
							if(session.LogicSettings.TransferDuplicatePokemon)
								await TransferDuplicatePokemonTask.Execute(session, cancellationToken);
							if(session.LogicSettings.TransferWeakPokemon)
								await TransferWeakPokemonTask.Execute(session, cancellationToken);
						}
                        else
                            session.EventDispatcher.Send(new WarnEvent
                            {
                                Message = session.Translation.GetTranslation(TranslationString.InvFullTransferManually)
                            });
                    }
                    else
                    {
                        session.EventDispatcher.Send(new WarnEvent
                        {
                            Message =
                                session.Translation.GetTranslation(TranslationString.EncounterProblem, encounter.Result)
                        });
                    }
                }
            }
        }
    }
}
