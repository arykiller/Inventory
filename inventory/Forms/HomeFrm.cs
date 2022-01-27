using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Itemfrm itemfrm = new Itemfrm();
            itemfrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsersFrm usersfrm = new UsersFrm();
            usersfrm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InventoryFrm inventoryfrm = new InventoryFrm(); 
            inventoryfrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransFrm transfrm = new TransFrm();
            transfrm.Show();
            this.Hide();
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {
            if (Program.role != "مسؤول")
            {
                button3.Enabled = false;
            }
        }

        private void LogoutBt_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            login.Show();
            this.Hide();
        }
    }
}
