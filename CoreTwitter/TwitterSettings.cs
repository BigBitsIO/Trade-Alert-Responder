using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTwitter
{
    public class TwitterSettings
    {
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string AccessToken { get; set; }
        public string AccessTokenSecret { get; set; }
        public bool Enabled { get; set; } = true;
        public bool VerifiedByUserAsWorking { get; set; } = false;
        public bool ScreenshotsInAlerts { get; set; } = false;
    }
}
