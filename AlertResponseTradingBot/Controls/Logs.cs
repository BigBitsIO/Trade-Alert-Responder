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
    public partial class Logs : UserControl
    {

        private int MaxLogs = 200;
        private BindingList<Core.Logs.LogMessage> LogMessages = new BindingList<Core.Logs.LogMessage>();

        public Logs()
        {
            InitializeComponent();
            List<Core.Logs.LogMessage> LogMessageList = new List<Core.Logs.LogMessage>();
            foreach (var log in LogMessageList)
                LogMessages.Add(log);
            
            Core.Logs.NewLog += NewLogMessage;
        }

        private void FormatGrid()
        {
        }

        private void NewLogMessage(object sender, AddingNewEventArgs e)
        {
            Core.Logs.LogMessage NewLog = e.NewObject as Core.Logs.LogMessage;
            LogMessages.Add(NewLog);
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            DataTable LogMessagesTable = DataHelper.ConvertToDataTable(LogMessages.OrderByDescending(a => a.DateLogged).Take(MaxLogs).ToList());
            grdLogs.DataSource = LogMessagesTable;
        }

        private void grdLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Core.Logs.Info("Test click log page");
        }

        private void grdLogs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                //switch (grdLogs.Rows[e.RowIndex].Cells[1].FormattedValue.ToString())
                //{
                //    case "Info":
                //        grdLogs.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.SkyBlue;
                //        break;
                //}
                grdLogs.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Core.Logs.LogColor(Core.Logs.LevelFromString(grdLogs.Rows[e.RowIndex].Cells[1].FormattedValue.ToString()));
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
