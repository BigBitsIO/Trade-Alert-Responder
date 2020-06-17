using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plugin;

namespace TradeAlertResponder.Controls
{
    public partial class AlertActionPluginContainer : UserControl
    {
        public AlertActionPluginContainer()
        {
            InitializeComponent();


            List<IAlertActionPlugin> ActionPlugins = AlertActionPluginLoader.Plugins;
            if (ActionPlugins.Any())
            {
                foreach (IAlertActionPlugin Plugin in ActionPlugins)
                {
                    AlertActionPlugin PluginControl = new AlertActionPlugin(Plugin);
                    pnlControlContainer.Controls.Add(PluginControl);
                    PluginControl.Dock = DockStyle.Top;
                }
            }

        }
    }
}
