using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.AlertScanPlugins
{
    public partial class TVAlertLogScanningLocalSettings : UserControl
    {
        public LocalSettings Settings = new LocalSettings();
        bool SettingsLoadedToForm = false;

        public TVAlertLogScanningLocalSettings(ref LocalSettings _Settings)
        {
            InitializeComponent();
            Settings = _Settings;
            LoadSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void LoadSettings()
        {
            numericUpDown1.Text = Settings.CustomScanDelay.ToString();
            checkBox1.Checked = Settings.UseCustomScanDelay;
            SettingsLoadedToForm = true;
        }

        private void SaveSettings()
        {
            if(SettingsLoadedToForm)
            {
                Settings.CustomScanDelay = (int)numericUpDown1.Value;
                Settings.UseCustomScanDelay = checkBox1.Checked;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
