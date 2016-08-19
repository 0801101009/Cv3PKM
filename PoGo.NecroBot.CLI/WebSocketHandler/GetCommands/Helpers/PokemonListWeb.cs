using Cv3PKM.Protos.Data;

namespace Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands
{
    public class PokemonListWeb
    {
        public PokemonData Base;

        public PokemonListWeb(PokemonData data)
        {
            Base = data;
        }

        public double IvPerfection
        {
            get
            {
                return Cv3PKM.Bot.Logic.PoGoUtils.PokemonInfo.CalculatePokemonPerfection(Base);
            }
        }

    }
}



