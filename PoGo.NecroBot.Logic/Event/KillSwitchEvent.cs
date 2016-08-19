using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv3PKM.Bot.Logic.Event
{
    public class KillSwitchEvent : IEvent
    {
        public string Message = string.Empty;
        public bool RequireStop;

        public override string ToString()
        {
            return Message;
        }
    }
}
