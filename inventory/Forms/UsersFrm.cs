using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq; //to Cast the Gridview in the foreach For Error in ugridView.rows CS1929 

namespace inventory
{
    public partial class UsersFrm : Form
    {
        public UsersFrm()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            uNameTx.Clear();
            uNameTx2.Clear();
            uPwdTx.Clear();
            uPwdTx2.Clear();
            uPwdCTx.Clear();
            uPwdCTx2.Clear();
            uRole.SelectedIndex = -1;
            uRole2.SelectedIndex = -1;
        }

        private void AddData()
        {
            //Adding Value from textbox to the Database
            Program.Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName, UserPwd, UserRole) VALUES('" + uNameTx.Text + "','" + uPwdTx.Text + "','" + uRole.Text + "');", Program.Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تم اضافة مستخدم بنجاح");
            Program.Con.Close();
            Clear();
            uGridView.DataSource = Program.populate("Users");
        }

        private void DeleteData()
        {
            //Get the Row index and its value from DataGridView Note: you must add using System.Linq;
            foreach (var cell in from DataGridViewRow row in uGridView.Rows
                                 where row.Selected
                                 from DataGridViewCell cell
                                 in row.Cells
                                 let index = cell.ColumnIndex
                                 where index == 0
                                 select cell)
            {
                //Message Box to confirm The delete of the User
                DialogResult d;
                d = MessageBox.Show("هل انت متاكد من حذف المستخدم ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    //Removing Record fro The database
                    Program.Con.Open();
                    //string myq = "DBCC CHECKIDENT ('users', RESEED, 0);";
                    String myQuery = "delete from Users where UserID = '" + cell.Value + "'";
                    SqlCommand cmd = new SqlCommand(myQuery, Program.Con);
                    //SqlCommand cmd2 = new SqlCommand(myq, Program.Con);
                    cmd.ExecuteNonQuery();
                    //cmd2.ExecuteNonQuery();
                    Program.Con.Close();
                    uGridView.DataSource = Program.populate("Users");
                    return;
                }

            }
            MessageBox.Show("الرجاء قم باختيار صف");
        }

        private void UpdateData()
        {
            foreach (var cell in from DataGridViewRow row in uGridView.Rows
                                 where row.Selected
                                 from DataGridViewCell cell in row.Cells
                                 let index = cell.ColumnIndex
                                 where index == 0
                                 select cell)
            {
                DialogResult d;
                d = MessageBox.Show("هل انت متاكد من تعديل هذا المستخدم", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    //Updating Value from textbox to the Database
                    Program.Con.Open();
                    SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET UserName='" + uNameTx2.Text + "',UserPwd='" + uPwdTx2.Text + "',UserRole='" + uRole2.Text + "'  where UserID = '" + cell.Value + "'", Program.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    Program.Con.Close();
                    uGridView.DataSource = Program.populate("Users");
                    Clear();
                    return;
                }

            }
            MessageBox.Show("الرجاء قم باختيار صف");
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void UsersFrm_Load(object sender, EventArgs e)
        {
            //Calling Function to add data into datagridview 
            uGridView.DataSource = Program.populate("Users");

            //Chanage the dataGridView Header text
            uGridView.Columns[0].HeaderText = "ت";
            uGridView.Columns[1].HeaderText = "اسم المستخدم";
            uGridView.Columns[2].HeaderText = "كلمة المرور";
            uGridView.Columns[3].HeaderText = "دور المستخدم";

        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            Program.GoHome();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uNameTx.Text))
            {
                errorProvider1.SetError(uNameTx, "الرجاء قم بادخال اسم المستخدم");
                return;
            }
            else if (String.IsNullOrEmpty(uPwdTx.Text))
            {
                errorProvider1.SetError(uPwdTx, "الرجاء قم بادخال كلمة المرور");
                return;
            }else if (String.IsNullOrEmpty(uPwdCTx.Text))
            {
                errorProvider1.SetError(uPwdCTx, "الرجاء قم بادخال بتاكيد كلمة المرور");
                return;
            }
            else if (uRole.SelectedIndex == -1)
            {
                errorProvider1.SetError(uRole, "الرجاء قم باختيار دور المستخدم");
                return;
            }
            else
            {
                AddData();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Show the password from * to the actual text
            if (showPwdCh.Checked)
            {
                uPwdTx.PasswordChar = '\0';
                uPwdCTx.PasswordChar = '\0';
            }
            else
            {
                uPwdTx.PasswordChar = '*';
                uPwdCTx.PasswordChar = '*';
            }
        }

        private void uRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(uRole, "");
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uNameTx2.Text))
            {
                errorProvider1.SetError(uNameTx2, "الرجاء قم بادخال اسم المستخدم");
                return;
            }
            else if (String.IsNullOrEmpty(uPwdTx2.Text))
            {
                errorProvider1.SetError(uPwdTx2, "الرجاء قم بادخال كلمة المرور");
                return;
            }
            else if (String.IsNullOrEmpty(uPwdCTx2.Text))
            {
                errorProvider1.SetError(uPwdCTx2, "الرجاء قم بادخال بتاكيد كلمة المرور");
                return;
            }
            else if (uRole2.SelectedIndex == -1)
            {
                errorProvider1.SetError(uRole2, "الرجاء قم باختيار دور المستخدم");
                return;
            }
            else
            {
                UpdateData();
            }
        }

        private void updateBtm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uNameTx2.Text))
            {
                errorProvider1.SetError(uNameTx2, "الرجاء قم بادخال اسم المستخدم");
                return;
            }
            else if (String.IsNullOrEmpty(uPwdTx2.Text))
            {
                errorProvider1.SetError(uPwdTx2, "الرجاء قم بادخال كلمة المرور");
                return;
            }
            else if (String.IsNullOrEmpty(uPwdCTx2.Text))
            {
                errorProvider1.SetError(uPwdCTx2, "الرجاء قم بادخال بتاكيد كلمة المرور");
                return;
            }
            else if (uRole2.SelectedIndex == -1)
            {
                errorProvider1.SetError(uRole2, "الرجاء قم باختيار دور المستخدم");
                return;
            }
            else
            {
                UpdateData();
            }
        }

        private void addBtm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uNameTx.Text))
            {
                errorProvider1.SetError(uNameTx, "الرجاء قم بادخال اسم المستخدم");
                return;
            }
            else if (String.IsNullOrEmpty(uPwdTx.Text))
            {
                errorProvider1.SetError(uPwdTx, "الرجاء قم بادخال كلمة المرور");
                return;
            }
            else if (String.IsNullOrEmpty(uPwdCTx.Text))
            {
                errorProvider1.SetError(uPwdCTx, "الرجاء قم بادخال بتاكيد كلمة المرور");
                return;
            }
            else if (uRole.SelectedIndex == -1)
            {
                errorProvider1.SetError(uRole, "الرجاء قم باختيار دور المستخدم");
                return;
            }
            else
            {
                AddData();
            }
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTx.Text))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users Where UserName = '" + searchTx.Text + "'"))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.Connection = Program.Con;
                        adapter.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            uGridView.DataSource = dt;
                        }
                    }
                }

            }
            else { MessageBox.Show("ادخل اسم المستخدم في صندوق البحث"); }
        }

        private void uNameTx2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(uNameTx2, "");
        }

        private void uNameTx_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(uNameTx, "");
        }

        private void uPwdTx_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(uPwdTx, "");
        }

        private void uPwdCTx_TextChanged(object sender, EventArgs e)
        {
            if (uPwdCTx.Text != uPwdTx.Text)
            {
                errorProvider1.SetError(uPwdCTx, "كلمة المرور غير متطابقة");
                return;
            }else
            {
                errorProvider1.SetError(uPwdCTx, "");
                return;
            }
        }

        private void uPwdTx2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(uPwdTx2, "");
        }

        private void uPwdCTx2_TextChanged(object sender, EventArgs e)
        {
            if (uPwdCTx2.Text != uPwdTx2.Text)
            {
                errorProvider1.SetError(uPwdCTx2, "كلمة المرور غير متطابقة");
                return;
            }
            else
            {
                errorProvider1.SetError(uPwdCTx2, "");
                return;
            }
        }

        private void uRole2_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(uRole2, "");
        }
    }
}