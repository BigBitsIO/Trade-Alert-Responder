using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.AlertActionPlugins
{
    public class DiscordAlertAction : IAlertActionPlugin
    {

        public string Name
        {
            get
            {
                return "Discord Alert Action";
            }
        }

        public string ShortName
        {
            get
            {
                return "Discord";
            }
        }

        public string Description
        {
            get
            {
                return "Will send a message to a text channel in Discord.";
            }
        }

        public AlertActionResult Action(Alert Alert)
        {
            return new AlertActionResult();
        }
    }
}
