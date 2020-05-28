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
using System.IO;
using System.Diagnostics;

namespace TradeAlertResponder.Controls
{
    public partial class AppInfo : UserControl
    {
        public AppInfo()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            lblAppName.Text = Constants.ProjectUserFriendlyName;
            lblVersion.Text = Constants.Version;
            lblCompany.Text = "Big Bits";
            lblCompanyWebsite.Text = "https://www.bigbits.io";
            lblAppGithub.Text = "https://github.com/BigBitsIO/Trade-Alert-Responder";
            lblAppFileLocation.Text = "%APPDATA%/Roaming/" + Constants.ProjectName;
            lblAuthors.Text = "David @ Big Bits";
            lblContributors.Text = "None so far - see contribution methods below.";

        }

        private void lblEthereumAddress_Click(object sender, EventArgs e)
        {
            Process.Start("https://etherscan.io/address/0x9790Cb4B3286741779ad0cC43aa31C7A2e435ac5");
        }

        private void lblBitcoinAddress_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.blockchain.com/btc/address/3Jr9eA3GgWXEVhxc5BGWPfq5EXT3ix8omD");
        }

        private void picBitcoin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.blockchain.com/btc/address/3Jr9eA3GgWXEVhxc5BGWPfq5EXT3ix8omD");
        }

        private void picEthereum_Click(object sender, EventArgs e)
        {
            Process.Start("https://etherscan.io/address/0x9790Cb4B3286741779ad0cC43aa31C7A2e435ac5");
        }

        private void lblCompanyWebsite_Click(object sender, EventArgs e)
        {
            Process.Start(lblCompanyWebsite.Text);
        }

        private void lblAppGithub_Click(object sender, EventArgs e)
        {
            Process.Start(lblAppGithub.Text);
        }
    }
    
}
