using Cv3PKM.Protos.Data;
using Cv3PKM.Protos.Data.Player;

namespace Cv3PKM.Bot.CLI.WebSocketHandler.GetCommands.Helpers
{
    class TrainerProfileWeb
    {
        public PlayerData Profile;
        public PlayerStats Stats;

        public TrainerProfileWeb(PlayerData profile, PlayerStats stats)
        {
            Profile = profile;
            Stats = stats;
        }
    }
}
