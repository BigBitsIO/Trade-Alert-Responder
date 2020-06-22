using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plugin.AlertActionPlugins;

namespace Plugin.AlertScanPlugins
{
    public partial class TwitterAlertActionSettings : UserControl
    {
        bool SettingsLoadedToForm = false;

        public TwitterAlertActionSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            chkIncludeScreenshot.Checked = Properties.Settings.Default.TwitterAlertsUseScreenshot;
            txtConsumerKey.Text = Properties.Settings.Default.TwitterAlertsConsumerKey;
            txtConsumerSecret.Text = Properties.Settings.Default.TwitterAlertsConsumerSecret;
            txtAccessToken.Text = Properties.Settings.Default.TwitterAlertsAccessToken;
            txtAccessTokenSecret.Text = Properties.Settings.Default.TwitterAlertsAccessTokenSecret;

            SettingsLoadedToForm = true;
        }

        private void SaveSettings()
        {
            try
            {
                if (SettingsLoadedToForm)
                {
                    Properties.Settings.Default.TwitterAlertsUseScreenshot = chkIncludeScreenshot.Checked;
                    Properties.Settings.Default.TwitterAlertsConsumerKey = txtConsumerKey.Text.Trim();
                    Properties.Settings.Default.TwitterAlertsConsumerSecret = txtConsumerSecret.Text.Trim();
                    Properties.Settings.Default.TwitterAlertsAccessToken = txtAccessToken.Text.Trim();
                    Properties.Settings.Default.TwitterAlertsAccessTokenSecret = txtAccessTokenSecret.Text.Trim();
                    Properties.Settings.Default.Save();

                }
            }
            catch(Exception ex)
            {

            }
            
        }


        private void chkIncludeScreenshot_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Task.Run(() => TwitterAlertAction.Twitter.Tweet("Testing Twitter Alerts - Alert Action Plugin for Trade Alert Responder!"));
        }

        private void txtAccessTokenSecret_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chkAccessTokenSecret_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccessTokenSecret.Checked)
            {
                txtAccessTokenSecret.PasswordChar = '*';
            }
            else
            {
                txtAccessTokenSecret.PasswordChar = '\0';
            }
        }

        private void txtConsumerKey_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chkConsumerKey_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsumerKey.Checked)
            {
                txtConsumerKey.PasswordChar = '*';
            }
            else
            {
                txtConsumerKey.PasswordChar = '\0';
            }
        }

        private void txtConsumerSecret_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chkConsumerSecret_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsumerSecret.Checked)
            {
                txtConsumerSecret.PasswordChar = '*';
            }
            else
            {
                txtConsumerSecret.PasswordChar = '\0';
            }
        }

        private void txtAccessToken_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chkAccessToken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccessToken.Checked)
            {
                txtAccessToken.PasswordChar = '*';
            }
            else
            {
                txtAccessToken.PasswordChar = '\0';
            }
        }
    }
}
