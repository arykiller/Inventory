using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace inventory
{
    internal static class Program
    {

        //Define Global Login Variables
        public static string role;

        //Define Connection String
        public static SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        //Function To open the home page
        public static void GoHome()
        {
            HomeFrm homeFrm = new HomeFrm();
            homeFrm.Show();
        }

        //Function to Get the number of database row
        public static String GetCount(String table)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) As Count FROM " + table + "", Program.Con))
            {
                cmd.CommandType = CommandType.Text;
                Program.Con.Open();
                object o = cmd.ExecuteScalar();
                if (o != null)
                {
                   return o.ToString();
                }
                Program.Con.Close();
                return "0";
            }
            
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeFrm());
        }
    }
}
