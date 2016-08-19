#region using directives

using System.Threading;
using System.Threading.Tasks;
using Cv3PKM.Bot.Logic.Tasks;

#endregion

namespace Cv3PKM.Bot.Logic.State
{
    public class InfoState : IState
    {
        public async Task<IState> Execute(ISession session, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            await DisplayPokemonStatsTask.Execute(session);
            return new FarmState();
        }
    }
}
