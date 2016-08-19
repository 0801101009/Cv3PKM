using System.Threading.Tasks;
using Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands.Tasks;
using Cv3PKM.Bot.Logic.State;
using SuperSocket.WebSocket;

namespace Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands
{
    public class GetPokemonListHandler : IWebSocketRequestHandler
    {
        public string Command { get; private set;}

        public GetPokemonListHandler()
        {
            Command = "GetPokemonList";
        }

        public async Task Handle(ISession session, WebSocketSession webSocketSession, dynamic message)
        {
            await GetPokemonListTask.Execute(session, webSocketSession, (string)message.RequestID);
        }
    }
}
