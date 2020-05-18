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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            IAlertScanPlugin Plugin = AlertScanPluginLoader.Plugins.Where(a => a.Name == ddlPlugin.SelectedValue).FirstOrDefault();

            TabPage TP = new TabPage(Plugin.ShortName);

            tabControlAlertScanners.TabPages.Add(TP);
            tabControlAlertScanners.SelectedTab = TP;

            AlertScanner AS = new AlertScanner(Plugin);

            TP.Controls.Add(AS);
            AS.Dock = DockStyle.Fill;
            
        }

        private void btnRemoveSelectedTab_Click(object sender, EventArgs e)
        {

            int SelectedIndex = tabControlAlertScanners.SelectedIndex;

            
            TabPage TP = tabControlAlertScanners.SelectedTab;
            if(TP != null)
                tabControlAlertScanners.TabPages.Remove(TP);

            if (SelectedIndex > 0)
            {
                tabControlAlertScanners.SelectedIndex = SelectedIndex - 1;
            }
        }
    }
}
