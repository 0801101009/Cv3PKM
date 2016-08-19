using System.Collections.Generic;
using Cv3PKM.Protos.Inventory.Item;

namespace Cv3PKM.Bot.Logic.Event
{
    public class InventoryListEvent : IEvent
    {
        public List<ItemData> Items;
    }
}
