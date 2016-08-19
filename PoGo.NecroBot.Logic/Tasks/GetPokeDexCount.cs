using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cv3PKM.Bot.Logic.Common;
using Cv3PKM.Bot.Logic.Logging;
using Cv3PKM.Bot.Logic.State;

namespace Cv3PKM.Bot.Logic.Tasks
{
    public class GetPokeDexCount
    {
        public static async Task Execute(ISession session, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await session.Inventory.RefreshCachedInventory();

            var PokeDex = await session.Inventory.GetPokeDexItems();
            var _totalUniqueEncounters = PokeDex.Select(i => new { Pokemon = i.InventoryItemData.PokedexEntry.PokemonId, Captures = i.InventoryItemData.PokedexEntry.TimesCaptured });
            var _totalCaptures = _totalUniqueEncounters.Count(i => i.Captures > 0);
            var _totalData = PokeDex.Count();
            
            Logger.Write(session.Translation.GetTranslation(TranslationString.AmountPkmSeenCaught, _totalData, _totalCaptures));
        }
    }
}