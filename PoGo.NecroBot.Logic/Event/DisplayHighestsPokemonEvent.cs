#region using directives

using System;
using System.Collections.Generic;
using Cv3PKM.Protos.Data;
using Cv3PKM.Protos.Enums;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class DisplayHighestsPokemonEvent : IEvent
    {
        //PokemonData | CP | IV | Level | MOVE1 | MOVE2 | Candy
        public List<Tuple<PokemonData, int, double, double, PokemonMove, PokemonMove, int>> PokemonList;
        public string SortedBy;
    }
}