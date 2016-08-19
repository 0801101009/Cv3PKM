#region using directives

using Cv3PKM.Protos.Enums;
using Cv3PKM.Protos.Networking.Responses;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class PokemonEvolveEvent : IEvent
    {
        public int Exp;
        public PokemonId Id;
        public ulong UniqueId;
        public EvolvePokemonResponse.Types.Result Result;
    }
}
