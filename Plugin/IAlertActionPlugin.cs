using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin
{
    public interface IAlertActionPlugin
    {
        string Name { get; }
        string ShortName { get; }
        string Description { get; }
        bool Enabled { get; set; }
        bool UseScreenshot { get;}
        AlertActionResult Action(Alert Alert);
        UserControl PluginSettings();
        UserControl About();



        string AuthorName { get; }
        string AuthorURL { get; }
    }

    public class AlertActionResult
    {
        public bool Succeeded { get; set; } = false;
        public string ErrorMessage { get; set; } = "";
    }
}
