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

namespace TradeAlertResponder
{
    public partial class AlertSettingsForm : MetroForm
    {

        private AlertSettings AlertSettings = new AlertSettings();

        public AlertSettingsForm(ref AlertSettings _AlertSettings)
        {
            InitializeComponent();

            if (_AlertSettings != null)
            {
                AlertSettings = _AlertSettings;

                tglNotificationOnAlert.Checked = AlertSettings.NotificationOnAlert;
                tglDiscordOnAlert.Checked = AlertSettings.DiscordOnAlert;
                tglTweetOnAlert.Checked = AlertSettings.TweetOnAlert;
                txtMyBotName.Text = AlertSettings.MyBotName;
                txtMyBotStatus.Text = AlertSettings.MyBotStatus;
                txtReferralsURL.Text = AlertSettings.ReferralURL;
                txtDisclaimerText.Text = AlertSettings.Disclaimertext;
            }
        }

        private void btnValidateAndSave_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Saved.";

            AlertSettings.NotificationOnAlert = tglNotificationOnAlert.Checked;
            AlertSettings.DiscordOnAlert = tglDiscordOnAlert.Checked;
            AlertSettings.TweetOnAlert = tglTweetOnAlert.Checked;
            AlertSettings.MyBotName = txtMyBotName.Text;
            AlertSettings.MyBotStatus = txtMyBotStatus.Text;
            AlertSettings.ReferralURL = txtReferralsURL.Text;
            AlertSettings.Disclaimertext = txtDisclaimerText.Text;

            FileHelper.ExportAlertSettings(AlertSettings).GetAwaiter().GetResult();
        }


    }
}
