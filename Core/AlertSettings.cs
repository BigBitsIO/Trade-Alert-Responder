using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AlertSettings
    {
        public string MyBotName { get; set; } = "MyBot";
        public string MyBotStatus { get; set; } = "Beta";
        public bool TweetOnAlert { get; set; } = false;
        public bool DiscordOnAlert { get; set; } = false;
        public bool NotificationOnAlert { get; set; } = false;
        public bool ShowUTCTimeStamp { get; set; } = false;
        public string ReferralURL { get; set; } = "https://bigbits.io/bigbits-referrals/";
        public string Disclaimertext { get; set; } = "!Not Financial Advice!";
    }
}
