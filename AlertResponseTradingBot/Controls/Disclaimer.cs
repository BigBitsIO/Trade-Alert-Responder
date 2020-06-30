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
            txtDisclaimer.Text = "This software is not perfect.  Bugs will exist and may impact performance. "
                + "This includes actions being duplicated, not executing, executing in an unexpected manner or in a way that breaks the application's running processes. "
                + "If you are using this application to perform actions that you consider vital or critical actions to you or your organization then you accept the risk that "
                + "this application can experience faults, faulures and otherwise unanticipated behavior in regards to any particular action the user assumes the application will complete."
                + Environment.NewLine + Environment.NewLine
                + "This software does not offer financial or trading advice.  Any decisions to make trades using any aspect of this software is "
                + "entirely the responsibility of the user.  Users of this software assume any and all risks associated with the application. "
                + "This project is free and open source, no warranties are provided for functionality.  Please only use this utility if you understand the risks. "
                + "Furthermore, this application can be modified using plugins.  Any risks or liability associated to the operation of a plugin added by the user "
                + "is also the responsibility of the user."
                + Environment.NewLine + Environment.NewLine
                + "Stocks, Options, Margin, Crypto, Derivatives, Futures, Forex, Tokens, any other type of trading or investment item involve a risk of capital loss. "
                + Environment.NewLine + Environment.NewLine
                + "Trading with any sort of margin or types of funds you have to borrow is considered to be extremely risky. "
                + Environment.NewLine + Environment.NewLine
                + "Cryptocurrencies and crypto based tokens are known to have very high levels of volitility and low levels of liquidity."
                + Environment.NewLine + Environment.NewLine
                + "Please consult a financial adviser if you plan on trading or investing."
                + Environment.NewLine + Environment.NewLine
                + "Big Bits and any of the plugins added to this application should never be considered as financial advisers or as to be offering financial advice. "
                + Environment.NewLine + Environment.NewLine
                + "All of the information available in this application is available as is and can not be confirmed to be entirely accurate. "
                + "Much of the information in the application is provided by third party websites or applications. "
                + "By using this software you agree that Big Bits can not be held responsible for any actions of the software or any incorrect or missing information.";
        }
    }
}
