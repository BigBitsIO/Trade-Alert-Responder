using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using CoreDiscord;

namespace TradeAlertResponder
{
    public partial class DiscordSettingsForm : MetroForm
    {

        private DiscordSettings DiscordSettings = new DiscordSettings();

        public DiscordSettingsForm(ref DiscordSettings _DiscordSettings)
        {
            InitializeComponent();

            if (_DiscordSettings != null)
            {
                DiscordSettings = _DiscordSettings;

                txtBotToken.Text = DiscordSettings.BotToken;
                txtGuildServerId.Text = DiscordSettings.GuildServerId.ToString();
                txtTextChannelId.Text = DiscordSettings.TextChannelId.ToString();
                tglValuesVerified.Checked = DiscordSettings.VerifiedByUserAsWorking;
                tglEnabled.Checked = DiscordSettings.Enabled;
                tglScreenshotsInAlerts.Checked = DiscordSettings.ScreenshotsInAlerts;
                tglTagHere.Checked = DiscordSettings.TagHere;
                tglTagEveryone.Checked = DiscordSettings.TagEveryone;
            }
        }

        private void btnValidateAndSave_Click(object sender, EventArgs e)
        {
                lblResult.Text = "Saved.";
            DiscordSettings.BotToken = txtBotToken.Text.Trim();
            DiscordSettings.GuildServerId = Convert.ToUInt64(txtGuildServerId.Text.Trim());
            DiscordSettings.TextChannelId = Convert.ToUInt64(txtTextChannelId.Text.Trim());
            DiscordSettings.VerifiedByUserAsWorking = tglValuesVerified.Checked;
            DiscordSettings.Enabled = tglEnabled.Checked;
            DiscordSettings.ScreenshotsInAlerts = tglScreenshotsInAlerts.Checked;
            DiscordSettings.TagHere = tglTagHere.Checked;
            DiscordSettings.TagEveryone = tglTagEveryone.Checked;
                FileHelper.ExportDiscordSettings(DiscordSettings).GetAwaiter().GetResult();
        }

        private void tglBotToken_CheckedChanged(object sender, EventArgs e)
        {
            if (tglBotToken.Checked)
            {
                txtBotToken.PasswordChar = '*';
            }
            else
            {
                txtBotToken.PasswordChar = '\0';
            }
        }

        private void tglGuildServerId_CheckedChanged(object sender, EventArgs e)
        {
            if (tglGuildServerId.Checked)
            {
                txtGuildServerId.PasswordChar = '*';
            }
            else
            {
                txtGuildServerId.PasswordChar = '\0';
            }
        }

        private void tglTextChannelId_CheckedChanged(object sender, EventArgs e)
        {
            if (tglTextChannelId.Checked)
            {
                txtTextChannelId.PasswordChar = '*';
            }
            else
            {
                txtTextChannelId.PasswordChar = '\0';
            }
        }
    }
}
