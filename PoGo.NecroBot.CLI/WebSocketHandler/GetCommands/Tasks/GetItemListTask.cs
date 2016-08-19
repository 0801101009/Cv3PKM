using System.Threading.Tasks;
using Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands.Events;
using Cv3PKM.Bot.Logic.State;
using SuperSocket.WebSocket;

namespace Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands.Tasks
{
    class GetItemListTask
    {
        public static async Task Execute(ISession session, WebSocketSession webSocketSession, string requestID)
        {
            var allItems = await session.Inventory.GetItems();
            webSocketSession.Send(EncodingHelper.Serialize(new ItemListResponce(allItems, requestID)));
        }
    }
}
