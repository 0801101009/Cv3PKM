#region using directives

using Cv3PKM.Bot.Logic.State;
using Cv3PKM.Bot.Logic.Tasks;

#endregion

namespace Cv3PKM.Bot.Logic.Service
{
    public class BotService
    {
        public ILogin LoginTask;
        public ISession Session;

        public void Run()
        {
            LoginTask.DoLogin();
        }
    }
}