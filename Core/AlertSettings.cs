using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AlertSettings
    {
        public bool TweetOnAlert { get; set; } = false;
        public bool DiscordOnAlert { get; set; } = false;
        public bool NotificationOnAlert { get; set; } = false;
    }
}
