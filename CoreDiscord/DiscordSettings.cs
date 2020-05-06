using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiscord
{
    public class DiscordSettings
    {
        public string BotToken { get; set; } = "";
        public ulong GuildServerId { get; set; } = 0;
        public ulong TextChannelId { get; set; } = 0;
        public bool Enabled { get; set; } = true;
        public bool VerifiedByUserAsWorking { get; set; } = false;
        public bool ScreenshotsInAlerts { get; set; } = false;
        public bool TagHere { get; set; } = false;
        public bool TagEveryone { get; set; } = false;
    }

}
