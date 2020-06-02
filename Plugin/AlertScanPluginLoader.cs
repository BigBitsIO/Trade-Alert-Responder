using Core;
using Plugin.AlertScanPlugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    public class AlertScanPluginLoader
    {
        public static List<IAlertScanPlugin> Plugins { get; set; }
        public static List<string> PluginDLLFileName { get; set; }

        public void LoadPlugins()
        {
            Plugins = new List<IAlertScanPlugin>();

            //Load the DLLs from the Plugins directory
            if (Directory.Exists(Constants.AlertScanPluginFolder))
            {
                string[] files = Directory.GetFiles(Constants.AlertScanPluginFolder);
                foreach (string file in files)
                {
                    if (file.EndsWith(".dll"))
                    {
                        Assembly.LoadFile(Path.GetFullPath(file));
                    }
                }
            }

            Type interfaceType = typeof(IAlertScanPlugin);
            //Fetch all types that implement the interface IPlugin and are a class
            Type[] types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
                .ToArray();
            foreach (Type type in types)
            {
                //Create a new instance of all found types
                Plugins.Add((IAlertScanPlugin)Activator.CreateInstance(type));
            }
        }
    }
}
