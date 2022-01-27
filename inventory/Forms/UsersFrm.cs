using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventory
{
    public partial class UsersFrm : Form
    {
        public UsersFrm()
        {
            InitializeComponent();
        } 
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void UsersFrm_Load(object sender, EventArgs e)
        {

        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            Program.GoHome();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
