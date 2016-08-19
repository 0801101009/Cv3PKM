#region using directives

using Cv3PKM.Bot.Logic.Common;
using Cv3PKM.Bot.Logic.Event;
using Cv3PKM.Bot.Logic.Service;
using Cv3PKM.RocketAPI;
using Cv3PKM.Protos.Networking.Responses;

#endregion

namespace Cv3PKM.Bot.Logic.State
{
    public interface ISession
    {
        ISettings Settings { get; set; }
        Inventory Inventory { get; }
        Client Client { get; }
        GetPlayerResponse Profile { get; set; }
        Navigation Navigation { get; }
        ILogicSettings LogicSettings { get; }
        ITranslation Translation { get; }
        IEventDispatcher EventDispatcher { get; }
        TelegramService Telegram { get; set; }
        KillSwitch KillSwitch { get; }
    }


    public class Session : ISession
    {
        public Session(ISettings settings, ILogicSettings logicSettings)
        {
            Settings = settings;
            LogicSettings = logicSettings;
            EventDispatcher = new EventDispatcher();
            Translation = Common.Translation.Load(logicSettings);
            Reset(settings, LogicSettings);
        }

        public ISettings Settings { get; set; }

        public Inventory Inventory { get; private set; }

        public Client Client { get; private set; }

        public GetPlayerResponse Profile { get; set; }
        public Navigation Navigation { get; private set; }

        public ILogicSettings LogicSettings { get; set; }

        public ITranslation Translation { get; }

        public IEventDispatcher EventDispatcher { get; }

        public TelegramService Telegram { get; set; }

        public KillSwitch KillSwitch { get; private set; }

        public void Reset(ISettings settings, ILogicSettings logicSettings)
        {
            ApiFailureStrategy _apiStrategy = new ApiFailureStrategy(this);
            Client = new Client(Settings, _apiStrategy);
            // ferox wants us to set this manually
            Inventory = new Inventory(Client, logicSettings);
            Navigation = new Navigation(Client);
            KillSwitch = new KillSwitch();
        }
    }
}