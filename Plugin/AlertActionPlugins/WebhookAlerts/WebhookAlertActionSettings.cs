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
using CoreWebRequest;

namespace Plugin.AlertScanPlugins
{
    public partial class WebhookAlertActionSettings : UserControl
    {
        bool SettingsLoadedToForm = false;

        public WebhookAlertActionSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            //chkIncludeScreenshot.Checked = Properties.Settings.Default.WebhookAlertsUseScreenshot;
            //chkTagEveryone.Checked = Properties.Settings.Default.WebhookAlertTagEveryone;
            //chkTagHere.Checked = Properties.Settings.Default.WebhookAlertTagHere;
            //txtBotToken.Text = Properties.Settings.Default.WebhookAlertBotToken;
            //txtGuildServerId.Text = Properties.Settings.Default.WebhookAlertGuildServerId;
            //txtTextChannelId.Text = Properties.Settings.Default.WebhookAlertTextChannelId;


            // USING JSON IN WH MESSAGE SHOULD BE AN ALERT PROPERTY SO EACH ALERT CAN BE CONFIGURED DIFFERENTLY

            SettingsLoadedToForm = true;
        }

        private void SaveSettings()
        {
            try
            {
                if (SettingsLoadedToForm)
                {
                    //Properties.Settings.Default.WebhookAlertsUseScreenshot = chkIncludeScreenshot.Checked;
                    //Properties.Settings.Default.WebhookAlertBotToken = txtBotToken.Text.Trim();
                    //Properties.Settings.Default.WebhookAlertGuildServerId = txtGuildServerId.Text.Trim();
                    //Properties.Settings.Default.WebhookAlertTextChannelId = txtTextChannelId.Text.Trim();
                    //Properties.Settings.Default.WebhookAlertTagHere = chkTagHere.Checked;
                    //Properties.Settings.Default.WebhookAlertTagEveryone = chkTagEveryone.Checked;
                    Properties.Settings.Default.Save();

                    //WebhookAlertAction.Webhook = WebhookAlertAction.NewWebhook();
                }
            }
            catch(Exception ex)
            {

            }
            
        }


      
        private void btnTest_Click(object sender, EventArgs e)
        {
            if(chkUseJSON.Checked)
            {
                Task.Run(() => WebRequest.POST(txtTestURL.Text.Trim(), "", true, txtTestMessage.Text.Trim()));
            }
            else
            {
                Task.Run(() => WebRequest.POST(txtTestURL.Text.Trim(), txtTestMessage.Text.Trim()));
            }
            
        }
    }
}
