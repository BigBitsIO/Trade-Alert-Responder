using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeAlertResponder
{
    public partial class Splash : Form
    {

        public Splash()
        {
            InitializeComponent();
        }

        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static Splash splash;

        static public void ShowSplashScreen()
        {
            //// Make sure it is only launched once.    
            //if (splash != null) return;
            //splash = new Splash();
            //Thread thread = new Thread(new ThreadStart(Splash.ShowForm));
            //thread.IsBackground = true;
            //thread.SetApartmentState(ApartmentState.STA);
            //thread.Start();
        }

        static private void ShowForm()
        {
            //if (splash != null) Application.Run(splash);

        }

        static public void CloseForm()
        {
            splash?.Invoke(new CloseDelegate(Splash.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            if (splash != null)
            {
                splash.Close();
                splash = null;
            };
        }
    }
}
