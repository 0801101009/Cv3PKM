using System.Linq;
using System.Threading.Tasks;
using Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands.Events;
using Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands.Helpers;
using Cv3PKM.Bot.Logic.State;
using SuperSocket.WebSocket;

namespace Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands.Tasks
{
    class GetTrainerProfileTask
    {
        public static async Task Execute(ISession session, WebSocketSession webSocketSession, string requestID)
        {
            var playerStats = (await session.Inventory.GetPlayerStats()).FirstOrDefault();
            if (playerStats == null)
                return;
            var tmpData = new TrainerProfileWeb(session.Profile.PlayerData, playerStats);
            webSocketSession.Send(EncodingHelper.Serialize(new TrainerProfileResponce(tmpData, requestID)));
        }
    }
}
