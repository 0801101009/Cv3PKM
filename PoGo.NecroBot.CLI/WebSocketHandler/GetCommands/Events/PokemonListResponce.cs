using Cv3PKM.Bot.Logic.Event;

namespace Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands.Events
{
    public class PokemonListResponce : IWebSocketResponce, IEvent
    {
        public PokemonListResponce(dynamic data, string requestID)
        {
            Command = "PokemonListWeb";
            Data = data;
            RequestID = requestID;
        }
        public string RequestID { get; private set; }
        public string Command { get; private set; }
        public dynamic Data { get; private set; }
    }
}
