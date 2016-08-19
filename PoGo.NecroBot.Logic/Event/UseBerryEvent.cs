using Cv3PKM.Protos.Inventory.Item;

namespace Cv3PKM.Bot.Logic.Event
{
    public class UseBerryEvent : IEvent
    {
        public ItemId BerryType;
        public int Count;
    }
}