#region using directives

using Cv3PKM.Protos.Enums;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class NoPokeballEvent : IEvent
    {
        public int Cp;
        public PokemonId Id;
    }
}