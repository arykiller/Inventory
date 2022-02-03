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
        public static bool emptyError;

        //Define Connection String
        //public static SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public static SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Projects\Programing\inventory\inventory\inventory.mdf;Integrated Security=True");
        //Function To open the home page
        public static void GoHome()
        {
            HomeFrm homeFrm = new HomeFrm();
            homeFrm.Show();
        }

        //Function to Get the number of database row
        public static String GetCount(String table)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) As Count FROM " + table + "", Con))
            {
                cmd.CommandType = CommandType.Text;
                Con.Open();
                object o = cmd.ExecuteScalar();
                if (o != null)
                {
                   return o.ToString();
                }
                Con.Close();
                return "0";
            }
            
        }
        //Display the Values on databse into the datagridview
        public static object populate(String table)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + ""))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.Connection = Con;
                    adapter.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
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
            Application.Run(new Itemfrm());
        }
    }
}
