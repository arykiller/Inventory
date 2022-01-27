using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            errorProvider1.SetError(UsernameTx, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UsernameTx.Text))
            {
                errorProvider1.SetError(UsernameTx, "الرجاء قم بادخال اسم المستخدم");
                return;
            }
            else if (String.IsNullOrEmpty(PwdTx.Text))
            {
                errorProvider1.SetError(PwdTx, "الرجاء قم بادخال كلمة المرور");
                return;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("Select  * From [Users] where [UserName]='" + UsernameTx.Text + "' and [UserPwd]='" + PwdTx.Text + "'", Program.Con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Program.role = ds.Tables[0].Rows[0][3].ToString();
                    Program.GoHome();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("كلمة المرور او اسم المستخدم غير صحيح !", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsernameTx.Clear();
                    PwdTx.Clear();
                    UsernameTx.Focus();
                }
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

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            Program.role = "زائر";
            Program.GoHome();
            this.Hide();
        }

        private void UsernameTx_Validating(object sender, CancelEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void PwdTx_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(PwdTx, "");
        }
    }

}
