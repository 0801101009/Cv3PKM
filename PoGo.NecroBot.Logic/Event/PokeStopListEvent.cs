#region using directives

using System.Collections.Generic;
using Cv3PKM.Protos.Map.Fort;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class PokeStopListEvent : IEvent
    {
        public List<FortData> Forts;
    }
}