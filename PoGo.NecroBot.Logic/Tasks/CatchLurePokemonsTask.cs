﻿#region using directives

using System.Threading;
using System.Threading.Tasks;
using Cv3PKM.Bot.Logic.Common;
using Cv3PKM.Bot.Logic.Event;
using Cv3PKM.Bot.Logic.Logging;
using Cv3PKM.Bot.Logic.State;
using Cv3PKM.Protos.Map.Fort;
using Cv3PKM.Protos.Networking.Responses;

#endregion

namespace Cv3PKM.Bot.Logic.Tasks
{
    public static class CatchLurePokemonsTask
    {
        public static async Task Execute(ISession session, FortData currentFortData, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (!session.LogicSettings.CatchPokemon) return;

            Logger.Write(session.Translation.GetTranslation(TranslationString.LookingForLurePokemon), LogLevel.Debug);

            var fortId = currentFortData.Id;

            var pokemonId = currentFortData.LureInfo.ActivePokemonId;

            if( ( session.LogicSettings.UsePokemonSniperFilterOnly && !session.LogicSettings.PokemonToSnipe.Pokemon.Contains( pokemonId ) ) ||
                    ( session.LogicSettings.UsePokemonToNotCatchFilter && session.LogicSettings.PokemonsNotToCatch.Contains( pokemonId ) ) )
            {
                session.EventDispatcher.Send(new NoticeEvent
                {
                    Message = session.Translation.GetTranslation(TranslationString.PokemonSkipped, pokemonId)
                });
            }
            else
            {
                var encounterId = currentFortData.LureInfo.EncounterId;
                var encounter = await session.Client.Encounter.EncounterLurePokemon(encounterId, fortId);

                if (encounter.Result == DiskEncounterResponse.Types.Result.Success && session.LogicSettings.CatchPokemon)
                {
                    await CatchPokemonTask.Execute(session, cancellationToken, encounter, null, currentFortData, encounterId);
                }
                else if (encounter.Result == DiskEncounterResponse.Types.Result.PokemonInventoryFull)
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
                    if (encounter.Result.ToString().Contains("NotAvailable")) return;
                    session.EventDispatcher.Send(new WarnEvent
                    {
                        Message =
                            session.Translation.GetTranslation(TranslationString.EncounterProblemLurePokemon,
                                encounter.Result)
                    });
                }
            }
        }
    }
}
