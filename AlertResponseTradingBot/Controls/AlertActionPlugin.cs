using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plugin;
using MetroFramework.Forms;
using System.Diagnostics;

namespace TradeAlertResponder.Controls
{
    public partial class AlertActionPlugin : UserControl
    {

        private IAlertActionPlugin Plugin;
        private MetroForm SettingsForm = new MetroForm();
        private MetroForm AboutForm = new MetroForm();
        private bool ControlLoaded = false;

        public AlertActionPlugin(IAlertActionPlugin _Plugin)
        {
            InitializeComponent();

            Plugin = _Plugin;
            lblPluginTextFriendlyName.Text = Plugin.Name;
            lblAuthor.Text = "Created By: " + Plugin.AuthorName;
            tglEnabled.Checked = Plugin.Enabled;

            ControlLoaded = true;


        }

        private void btnPluginSettings_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm = new MetroForm();
            AboutForm.Resizable = false;
            AboutForm.Theme = MetroFramework.MetroThemeStyle.Dark;
            AboutForm.Style = MetroFramework.MetroColorStyle.White;
            AboutForm.ShadowType = MetroFormShadowType.DropShadow;
            AboutForm.MinimizeBox = false;
            AboutForm.MaximizeBox = false;
            UserControl AboutControl = Plugin.About();
            AboutForm.Size = new Size(AboutControl.Size.Width + 100, AboutControl.Height + 100);
            AboutForm.Controls.Add(AboutControl);
            AboutControl.Dock = DockStyle.Fill;
            AboutForm.Show();
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(Plugin.AuthorURL, UriKind.Absolute))
                Process.Start(Plugin.AuthorURL);
        }

        private void tglEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if(ControlLoaded) // Prevents this action from setting value before the form is fully loaded, and changed
                Plugin.Enabled = tglEnabled.Checked;
        }

        private void btnPluginSettings_Click_1(object sender, EventArgs e)
        {
            SettingsForm = new MetroForm();
            SettingsForm.Resizable = false;
            SettingsForm.Theme = MetroFramework.MetroThemeStyle.Dark;
            SettingsForm.Style = MetroFramework.MetroColorStyle.White;
            SettingsForm.ShadowType = MetroFormShadowType.DropShadow;
            SettingsForm.MinimizeBox = false;
            SettingsForm.MaximizeBox = false;
            UserControl SettingsControl = Plugin.PluginSettings();
            SettingsForm.Size = new Size(SettingsControl.Size.Width + 100, SettingsControl.Height + 100);
            SettingsForm.Controls.Add(SettingsControl);
            SettingsControl.Dock = DockStyle.Fill;
            SettingsForm.Show();
        }
    }
}
