using System;
using System.Windows.Forms;

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
            Program.Back();
            this.Hide();
        }
    }
}
