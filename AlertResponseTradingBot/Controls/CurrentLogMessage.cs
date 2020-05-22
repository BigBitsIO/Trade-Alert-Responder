using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeAlertResponder.Controls
{
    public partial class CurrentLogMessage : UserControl
    {
        public CurrentLogMessage()
        {
            InitializeComponent();
            Logs.NewLog += NewLogMessage;
        }

        private void NewLogMessage(object sender, AddingNewEventArgs e)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((Action)(() => NewLogMessage(sender, e)));
                    return;
                }

                Logs.LogMessage Message = e.NewObject as Logs.LogMessage;
                if (Message.Level == Logs.LogLevel.Info)
                {
                    SetLogMessage(Message);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SetLogMessage(Logs.LogMessage Log)
        {
            lblMessage.Text = Log.DateLogged.ToLongTimeString() + " " + Log.Level.ToString() + ": " + Log.Message;
            if (Log.Level == Logs.LogLevel.Info)
                lblMessage.ForeColor = Color.Teal;
            if (Log.Level == Logs.LogLevel.Error)
                lblMessage.ForeColor = Color.Red;
            if (Log.Level == Logs.LogLevel.Warning)
                lblMessage.ForeColor = Color.Orange;
            if (Log.Level == Logs.LogLevel.Debug)
                lblMessage.ForeColor = Color.Pink;
        }
    }
}
