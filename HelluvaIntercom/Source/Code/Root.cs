using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using CefSharp;
using CefSharp.WinForms;

namespace HelluvaIntercom
{
    static class Root
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var settings = new CefSettings();
            settings.CachePath = $@"{Application.StartupPath}\CEF\CEFCache";
            settings.LocalesDirPath = $@"{Application.StartupPath}\CEF\CEFLocalesDir";
            settings.UserDataPath = $@"{Application.StartupPath}\CEF\CEFUserData";

            Cef.Initialize(settings);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrameForm());
            
        }
    }
}
