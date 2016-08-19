#region using directives

using Cv3PKM.Protos.Enums;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class EggHatchedEvent : IEvent
    {
        public int Cp;
        public ulong Id;
        public double Level;
        public int MaxCp;
        public double Perfection;
        public PokemonId PokemonId;
    }
}