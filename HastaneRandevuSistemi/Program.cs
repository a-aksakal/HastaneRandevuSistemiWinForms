using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
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
            Application.Run(new Forms.MainPage());
            
        }
        public static string connectionString = "Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True";
    }
}
