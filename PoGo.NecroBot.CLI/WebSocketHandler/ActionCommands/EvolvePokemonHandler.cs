using System.Threading.Tasks;
using Cv3PKM.Bot.Logic.State;
using SuperSocket.WebSocket;

namespace Cv3PKM.Bot.CLI.WebSocketHandler.ActionCommands
{
    public class EvolvePokemonHandler : IWebSocketRequestHandler
    {
        public string Command { get; private set;}

        public EvolvePokemonHandler()
        {
            Command = "EvolvePokemon";
        }

        public async Task Handle(ISession session, WebSocketSession webSocketSession, dynamic message)
        {
            await Cv3PKM.Bot.Logic.Tasks.EvolveSpecificPokemonTask.Execute(session, (ulong)message.PokemonId);
        }
    }
}