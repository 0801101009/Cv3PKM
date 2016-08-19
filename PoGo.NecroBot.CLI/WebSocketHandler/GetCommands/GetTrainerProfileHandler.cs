using System.Threading.Tasks;
using Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands.Tasks;
using Cv3PKM.Bot.Logic.State;
using SuperSocket.WebSocket;

namespace Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands
{
    class GetTrainerProfileHandler : IWebSocketRequestHandler
    {

        public string Command { get; private set; }

        public GetTrainerProfileHandler()
        {
            Command = "GetTrainerProfile";
        }

        public async Task Handle(ISession session, WebSocketSession webSocketSession, dynamic message)
        {
            await GetTrainerProfileTask.Execute(session, webSocketSession, (string)message.RequestID);
        }
    }
}
