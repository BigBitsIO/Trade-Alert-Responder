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
    public partial class Disclaimer : UserControl
    {
        public Disclaimer()
        {
            InitializeComponent();
            LoadDisclaimerText();
        }

        private void LoadDisclaimerText()
        {
            txtDisclaimer.Text = "This software does not offer financial or trading advice.  Any decisions to make trades using any aspect of this software is "
                + "entirely the responsibility of the user.  Users of this software assume any and all risks associated with the application. "
                + "This project is free and open source, no warranties are provided for functionality.  Please only use this utility if you understand the risks. "
                + "Furthermore, this application can be modified using plugins.  Any risks or liability associated to the operation of a plugin added by the user "
                + "is also the responsibility of the user.";
        }
    }
}
