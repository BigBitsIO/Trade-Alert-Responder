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
    public partial class TVAlertLogScanningGlobalSettings : UserControl
    {
        public TVAlertLogScanningGlobalSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            SaveSettings();
        }

        private void LoadSettings()
        {
            textBox1.Text = Properties.Settings.Default.TVAlertLogScanningDelay.ToString();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.TVAlertLogScanningDelay = Convert.ToInt32(textBox1.Text);
            Properties.Settings.Default.Save();
        }
    }
}
