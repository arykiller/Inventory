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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.userName = UsernameTx.Text;
            Program.password = PwdTx.Text;
            if (Program.userName == "admin" && Program.password == "0000")
            {
                Program.role = 0;
                Program.Back();
                this.Hide();
            }
            else
            {
                UsernameTx.Clear();
                PwdTx.Clear();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPwdCb.Checked)
            {
                PwdTx.PasswordChar = '\0';
            }
            else
            {
                PwdTx.PasswordChar = '*';
            }
        }
    }
}
