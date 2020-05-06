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
using CoreTwitter;

namespace TradeAlertResponder
{
    public partial class TwitterSettingsForm : MetroForm
    {

        private TwitterSettings TwitterSettings = new TwitterSettings();

        public TwitterSettingsForm(ref TwitterSettings _TwitterSettings)
        {
            InitializeComponent();

            TwitterSettings = _TwitterSettings;

            txtConsumerKey.Text = TwitterSettings.ConsumerKey;
            txtConsumerSecret.Text = TwitterSettings.ConsumerSecret;
            txtAccessToken.Text = TwitterSettings.AccessToken;
            txtAccessTokenSecret.Text = TwitterSettings.AccessTokenSecret;
            tglValuesVerified.Checked = TwitterSettings.VerifiedByUserAsWorking;
            tglEnabled.Checked = TwitterSettings.Enabled;
            tglScreenshotsInAlerts.Checked = TwitterSettings.ScreenshotsInAlerts;
        }

        private void btnValidateAndSave_Click_1(object sender, EventArgs e)
        {
            lblResult.Text = "Saved.";
            TwitterSettings.ConsumerKey = txtConsumerKey.Text.Trim();
            TwitterSettings.ConsumerSecret = txtConsumerSecret.Text.Trim();
            TwitterSettings.AccessToken = txtAccessToken.Text.Trim();
            TwitterSettings.AccessTokenSecret = txtAccessTokenSecret.Text.Trim();
            TwitterSettings.Enabled = tglEnabled.Checked;
            TwitterSettings.VerifiedByUserAsWorking = tglValuesVerified.Checked;
            TwitterSettings.ScreenshotsInAlerts = tglScreenshotsInAlerts.Checked;
            FileHelper.ExportTwitterSettings(TwitterSettings).GetAwaiter().GetResult();
        }

        private void tglConsumerKey_CheckedChanged(object sender, EventArgs e)
        {
            if (tglConsumerKey.Checked)
            {
                txtConsumerKey.PasswordChar = '*';
            }
            else
            {
                txtConsumerKey.PasswordChar = '\0';
            }
        }

        private void tglConsumerSecret_CheckedChanged(object sender, EventArgs e)
        {
            if (tglConsumerSecret.Checked)
            {
                txtConsumerSecret.PasswordChar = '*';
            }
            else
            {
                txtConsumerSecret.PasswordChar = '\0';
            }
        }

        private void tglAccessToken_CheckedChanged(object sender, EventArgs e)
        {
            if (tglAccessToken.Checked)
            {
                txtAccessToken.PasswordChar = '*';
            }
            else
            {
                txtAccessToken.PasswordChar = '\0';
            }
        }

        private void tglAccessTokenSecret_CheckedChanged(object sender, EventArgs e)
        {
            if (tglAccessTokenSecret.Checked)
            {
                txtAccessTokenSecret.PasswordChar = '*';
            }
            else
            {
                txtAccessTokenSecret.PasswordChar = '\0';
            }
        }

        
    }
}
