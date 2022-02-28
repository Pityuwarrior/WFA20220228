using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA20220114
{
    static class Program
    {
        /*
        internal static string ConnectionString => 
            "Server = (localdb)\\MSSQLLocalDB;" +
            "Database = nyelviskola;" +
            "Integrated Security = True;";
        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
