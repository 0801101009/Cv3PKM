#region using directives

using Cv3PKM.Protos.Enums;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class TransferPokemonEvent : IEvent
    {
        public int BestCp;
        public double BestPerfection;
        public int Cp;
        public int FamilyCandies;
        public PokemonId Id;
        public double Perfection;
    }
}