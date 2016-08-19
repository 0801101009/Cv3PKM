#region using directives

using Cv3PKM.Protos.Inventory.Item;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class ItemRecycledEvent : IEvent
    {
        public int Count;
        public ItemId Id;
    }
}