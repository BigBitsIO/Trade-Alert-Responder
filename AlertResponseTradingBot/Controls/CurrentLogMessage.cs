using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace TradeAlertResponder.Controls
{
    public partial class CurrentLogMessage : UserControl
    {
        public CurrentLogMessage()
        {
            InitializeComponent();
            Core.Logs.NewLog += NewLogMessage;
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

                Core.Logs.LogMessage Message = e.NewObject as Core.Logs.LogMessage;
                if (Message.Level == Core.Logs.LogLevel.Info)
                {
                    SetLogMessage(Message);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SetLogMessage(Core.Logs.LogMessage Log)
        {
            lblMessage.Text = Log.DateLogged.ToLongTimeString() + " " + Log.Level.ToString() + ": " + Log.Message;
            lblMessage.ForeColor = Core.Logs.LogColor(Log.Level);
        }
    }
}
