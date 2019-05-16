using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace core30start
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);


            Application.Run(new ppedv.FlyingPluto.UI.WinForms.Form1());
        }
    }
}
