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
    }
    
}
