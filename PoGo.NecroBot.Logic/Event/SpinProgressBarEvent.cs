﻿namespace Cv3PKM.Bot.Logic.Event
{
    public class SpinProgressBarEvent : IEvent
    {
        public string Message = string.Empty;
        public bool IsWorking;

        public override string ToString()
        {
            return Message;
        }
    }
}
