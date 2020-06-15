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
    public partial class DiscordAlertActionSettings : UserControl
    {
        bool SettingsLoadedToForm = false;

        public DiscordAlertActionSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            //numericUpDown1.Value = Properties.Settings.Default.TVAlertLogScanningDelay;
            //SettingsLoadedToForm = true;
        }

        private void SaveSettings()
        {
            if(SettingsLoadedToForm)
            {
                //Properties.Settings.Default.TVAlertLogScanningDelay = Convert.ToInt32((int)numericUpDown1.Value);
                //Properties.Settings.Default.Save();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
