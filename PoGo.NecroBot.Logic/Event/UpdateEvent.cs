﻿namespace Cv3PKM.Bot.Logic.Event
{
    public class UpdateEvent : IEvent
    {
        public string Message = "";

        public override string ToString()
        {
            return Message;
        }
    }
}