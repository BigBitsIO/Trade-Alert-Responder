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
using MetroFramework.Forms;
using TradeAlertResponder.Properties;

namespace TradeAlertResponder.Controls
{
    public partial class AlertScannerContainer : UserControl
    {

        private IAlertScanPlugin Plugin;
        private MetroForm SettingsForm = new MetroForm();

        public AlertScannerContainer()
        {
            InitializeComponent();
            LoadPlugins();

            if(AlertScanPluginLoader.Plugins.Any(a => a.Name == "TradingView Alert Log Scanning"))
            {
                Plugin = AlertScanPluginLoader.Plugins.Where(a => a.Name == "TradingView Alert Log Scanning").FirstOrDefault();
                AddTab(Plugin);
            }
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
            IAlertScanPlugin Plugin = AlertScanPluginLoader.Plugins.Where(a => a.Name == (string)ddlPlugin.SelectedValue).FirstOrDefault();

            AddTab(Plugin);
            
        }

        private void AddTab(IAlertScanPlugin Plugin)
        {
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm = new MetroForm();
            UserControl SettingsControl = Plugin.PluginGlobalSettings();
            SettingsForm.Size = SettingsControl.Size;
            SettingsForm.Controls.Add(SettingsControl);
            SettingsControl.Dock = DockStyle.Fill;
            SettingsForm.Show();
        }
    }
}
