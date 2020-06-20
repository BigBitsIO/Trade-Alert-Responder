using Core;
using CoreDiscord;
using Plugin.AlertScanPlugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.AlertActionPlugins
{
    public class DiscordAlertAction : IAlertActionPlugin
    {

        public static Discord Discord = NewDiscord();

        public string Name
        {
            get
            {
                return "Discord Alerts";
            }
        }

        public string ShortName
        {
            get
            {
                return "Discord Alerts";
            }
        }

        public string Description
        {
            get
            {
                return "Will send a message to a text channel in Discord.";
            }
        }

        public bool Enabled
        {
            get
            {
                return GetEnabledSetting();
            }
            set
            {
                Properties.Settings.Default.DiscordAlertsEnabled = value;
                Properties.Settings.Default.Save();
            }
        }

        public string AuthorName
        {
            get
            {
                return "Big Bits";
            }
        }

        public string AuthorURL
        {
            get
            {
                return "https://www.bigbits.io";
            }
        }

        public bool UseScreenshot
        {
            get
            {
                return GetUseScreenshotSetting();
            }
        }

        public UserControl About()
        {
            return new DiscordAlertActionAbout();
        }

        public AlertActionResult Action(Alert Alert)
        {
            return new AlertActionResult();
        }

        public UserControl PluginSettings()
        {
            return new DiscordAlertActionSettings();
        }

        private bool GetEnabledSetting()
        {
            return Properties.Settings.Default.DiscordAlertsEnabled;
        }

        private bool GetUseScreenshotSetting()
        {
            return Properties.Settings.Default.DiscordAlertsUseScreenshot;
        }

        public static Discord NewDiscord()
        {
            try
            {
                return new Discord(Properties.Settings.Default.DiscordAlertBotToken, Convert.ToUInt64(Properties.Settings.Default.DiscordAlertGuildServerId), Convert.ToUInt64(Properties.Settings.Default.DiscordAlertTextChannelId));
            }
            catch(Exception ex)
            {
                return new Discord("", 0, 0);
            }
            
        }

    }
}
