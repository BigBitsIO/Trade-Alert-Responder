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

        public TVAlertLogScanningLocalSettings(ref LocalSettings _Settings)
        {
            InitializeComponent();
            Settings = _Settings;
            LoadSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            SaveSettings();
        }

        private void LoadSettings()
        {
            textBox1.Text = Settings.CustomScanDelay.ToString();
            checkBox1.Checked = Settings.UseCustomScanDelay;
        }

        private void SaveSettings()
        {
            Settings.CustomScanDelay = Convert.ToInt32(textBox1.Text);
            Settings.UseCustomScanDelay = checkBox1.Checked;
        }
    }
}
