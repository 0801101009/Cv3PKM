#region using directives

using Cv3PKM.Protos.Enums;
using Cv3PKM.Protos.Inventory.Item;
using Cv3PKM.Protos.Networking.Responses;

#endregion

namespace Cv3PKM.Bot.Logic.Event
{
    public class PokemonCaptureEvent : IEvent
    {
        public int Attempt;
        public int BallAmount;
        public string CatchType;
        public int Cp;
        public double Distance;
        public int Exp;
        public int FamilyCandies;
        public PokemonId Id;
        public ulong UniqueId;
        public double Level;
        public int MaxCp;
        public double Perfection;
        public ItemId Pokeball;
        public double Probability;
        public int Stardust;
        public CatchPokemonResponse.Types.CatchStatus Status;
        public double Latitude;
        public double Longitude;
    }
}
