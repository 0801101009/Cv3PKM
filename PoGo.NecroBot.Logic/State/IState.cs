#region using directives

using System.Threading;
using System.Threading.Tasks;

#endregion

namespace Cv3PKM.Bot.Logic.State
{
    public interface IState
    {
        Task<IState> Execute(ISession session, CancellationToken cancellationToken);
    }
}