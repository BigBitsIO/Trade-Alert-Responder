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
using CoreWordPress;

namespace Plugin.AlertScanPlugins
{
    public partial class WordPressAlertActionSettings : UserControl
    {
        bool SettingsLoadedToForm = false;

        public WordPressAlertActionSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            chkIncludeScreenshot.Checked = Properties.Settings.Default.WordPressAlertsUseScreenshot;
            txtURL.Text = Properties.Settings.Default.WordPressAlertAPIURL;
            txtUser.Text = Properties.Settings.Default.WordPressAlertAPIUser;
            txtPassword.Text = Properties.Settings.Default.WordPressAlertAPIUserPassword;

            SettingsLoadedToForm = true;
        }

        private void SaveSettings()
        {
            try
            {
                if (SettingsLoadedToForm)
                {
                    Properties.Settings.Default.WordPressAlertsUseScreenshot = chkIncludeScreenshot.Checked;
                    Properties.Settings.Default.WordPressAlertAPIURL = txtURL.Text.Trim();
                    Properties.Settings.Default.WordPressAlertAPIUser = txtUser.Text.Trim();
                    Properties.Settings.Default.WordPressAlertAPIUserPassword = txtPassword.Text.Trim();
                    Properties.Settings.Default.Save();

                    WordPressAlertAction.WordPress = WordPressAlertAction.NewWordPress();
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chkURL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkURL.Checked)
            {
                txtURL.PasswordChar = '*';
            }
            else
            {
                txtURL.PasswordChar = '\0';
            }
        }

        private void chkUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUser.Checked)
            {
                txtUser.PasswordChar = '*';
            }
            else
            {
                txtUser.PasswordChar = '\0';
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void chkIncludeScreenshot_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
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
            List<string> TestTagList = new List<string>();
            TestTagList.Add("Test");
            TestTagList.Add("TradeAlertResponder");
            TestTagList.Add("TradingAlerts");


            List<string> TestCategoriesList = new List<string>();
            TestCategoriesList.Add("TestPost");


            Task.Run(() => WordPressAlertAction.WordPress.PostWithFeaturedImageURL("Trade Alert Responder - Test Post!",
                "<h1>This is a test post from the Trade Alert Responder application created by Big Bits!</h1>",
                TestTagList,
                TestCategoriesList,
                "https://bigbits.io/wp-content/uploads/2019/10/mockup-76f7725f.png"));
        }
    }
}
