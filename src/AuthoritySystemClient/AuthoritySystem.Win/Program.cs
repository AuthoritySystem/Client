using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthoritySystem.Win
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //var configurationBuilder = new ConfigurationBuilder();
            ////configurationBuilder.AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
            //configurationBuilder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //configurationBuilder.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
