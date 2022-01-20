using Raph.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raph
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.AddInstance();
            Application.Run(new Home(GlobalConfig.IAuthRepo,GlobalConfig.ICustRepo,GlobalConfig.IAccountRepo,GlobalConfig.ITransactRepo));
        }
    }
}
