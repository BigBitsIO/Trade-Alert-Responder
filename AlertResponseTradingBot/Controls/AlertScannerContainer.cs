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
    public partial class AlertScannerContainer : UserControl
    {
        public AlertScannerContainer()
        {
            InitializeComponent();
            LoadPlugins();
        }

        private void LoadPlugins()
        {

            ddlPlugin.DataSource = AlertScanPluginLoader.Plugins;
            ddlPlugin.DisplayMember = "Name";
            ddlPlugin.ValueMember = "Name";

            ddlPlugin.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
