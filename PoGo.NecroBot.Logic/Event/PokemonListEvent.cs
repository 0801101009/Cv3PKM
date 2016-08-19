#region using directives

using System;
using System.Collections.Generic;
using Cv3PKM.Protos.Data;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class PokemonListEvent : IEvent
    {
        public List<Tuple<PokemonData, double, int>> PokemonList;
    }
}