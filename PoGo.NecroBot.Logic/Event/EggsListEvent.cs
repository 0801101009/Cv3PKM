#region using directives

using System.Collections.Generic;
using Cv3PKM.Protos.Inventory;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class EggsListEvent : IEvent
    {
        public float PlayerKmWalked { get; set; }
        public List<EggIncubator> Incubators { get; set; }
        public object UnusedEggs { get; set; }
    }
}