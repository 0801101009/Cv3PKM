﻿using System.Threading;
using System.Threading.Tasks;
using Cv3PKM.Bot.Logic.Common;
using Cv3PKM.Bot.Logic.Logging;
using Cv3PKM.Bot.Logic.State;
using Cv3PKM.Protos.Inventory.Item;
using Cv3PKM.Protos.Networking.Responses;

namespace Cv3PKM.Bot.Logic.Tasks
{
    public class UseIncenseConstantlyTask
    {
        public static async Task Execute(ISession session, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await session.Inventory.RefreshCachedInventory();

            var currentAmountOfIncense = await session.Inventory.GetItemAmountByType(ItemId.ItemIncenseOrdinary);
            if (currentAmountOfIncense == 0)
            {
                Logger.Write(session.Translation.GetTranslation(TranslationString.NoIncenseAvailable));
                return;
            }
            else
            {
                Logger.Write(session.Translation.GetTranslation(TranslationString.UseIncenseAmount, currentAmountOfIncense));
            }

            var UseIncense = await session.Inventory.UseIncenseConstantly();

            if (UseIncense.Result == UseIncenseResponse.Types.Result.Success)
            {
                Logger.Write(session.Translation.GetTranslation(TranslationString.UsedIncense));
            }
            else if (UseIncense.Result == UseIncenseResponse.Types.Result.NoneInInventory)
            {
                Logger.Write(session.Translation.GetTranslation(TranslationString.NoIncenseAvailable));
            }
            else if (UseIncense.Result == UseIncenseResponse.Types.Result.IncenseAlreadyActive || (UseIncense.AppliedIncense == null))
            {
                Logger.Write(session.Translation.GetTranslation(TranslationString.UseIncenseActive));
            }
        }
    }
}
