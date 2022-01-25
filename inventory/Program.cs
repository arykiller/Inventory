using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    internal static class Program
    {
        //Define Global Login Variables
        public static int role;
        public static string userName;
        public static string password;
        //Function To go back in the Forms
        public static void Back()
        {
            HomeFrm homeFrm = new HomeFrm();
            homeFrm.Show();
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginFrm());
        }
    }
}
