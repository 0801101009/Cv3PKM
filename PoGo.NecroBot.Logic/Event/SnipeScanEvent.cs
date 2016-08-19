#region using directives

using Cv3PKM.Protos.Enums;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class SnipeScanEvent : IEvent
    {
        public Location Bounds { get; set; }
        public PokemonId PokemonId { get; set; }
        public double Iv { get; set; }
        public string Source { get; set; }
    }
}