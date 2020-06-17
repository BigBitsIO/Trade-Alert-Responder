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
            chkIncludeScreenshot.Checked = Properties.Settings.Default.DiscordAlertsUseScreenshot;
            txtBotToken.Text = Properties.Settings.Default.DiscordAlertBotToken;
            txtGuildServerId.Text = Properties.Settings.Default.DiscordAlertGuildServerId;
            txtTextChannelId.Text = Properties.Settings.Default.DiscordAlertTextChannelId;

            SettingsLoadedToForm = true;
        }

        private void SaveSettings()
        {
            if(SettingsLoadedToForm)
            {
                Properties.Settings.Default.DiscordAlertsUseScreenshot = chkIncludeScreenshot.Checked;
                Properties.Settings.Default.DiscordAlertBotToken = txtBotToken.Text.Trim();
                Properties.Settings.Default.DiscordAlertGuildServerId = txtGuildServerId.Text.Trim();
                Properties.Settings.Default.DiscordAlertTextChannelId = txtTextChannelId.Text.Trim();
                Properties.Settings.Default.Save();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chkBotToken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBotToken.Checked)
            {
                txtBotToken.PasswordChar = '*';
            }
            else
            {
                txtBotToken.PasswordChar = '\0';
            }
        }

        private void chkGuildServerId_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGuildServerId.Checked)
            {
                txtGuildServerId.PasswordChar = '*';
            }
            else
            {
                txtGuildServerId.PasswordChar = '\0';
            }
        }

        private void chkTextChannelId_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTextChannelId.Checked)
            {
                txtTextChannelId.PasswordChar = '*';
            }
            else
            {
                txtTextChannelId.PasswordChar = '\0';
            }
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chkIncludeScreenshot_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chkTagHere_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chkTagEveryone_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtBotToken_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtGuildServerId_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtTextChannelId_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
