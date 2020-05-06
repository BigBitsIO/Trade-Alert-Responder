using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeAlertResponder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine(e.ExceptionObject.ToString());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Exception.ToString());
            Console.WriteLine(e.Exception.ToString());
        }

        private static void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("First Chance Exception: " + e.Exception.ToString());
            Console.WriteLine("First Chance Exception: " + e.Exception.ToString());
        }

        private static void LogSystemError(Exception ex)
        {
            ILog logger = LogManager.GetLogger(typeof(Program));
            logger.Debug(ex.ToString());
        }
    }
}
