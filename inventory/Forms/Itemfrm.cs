using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventory
{
    public partial class Itemfrm : Form
    {
        public Itemfrm()
        {
            InitializeComponent();
        }
        private void populate()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * ,CASE WHEN Quntity > 0 THEN 'متوفر' ELSE 'غير متوفر' END AS State FROM Items;"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.Connection = Program.Con;
                    adapter.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        iGridView.DataSource = dt;
                    }
                }
            }

        }
        private void Clear()
        {
            itemTx.Clear();
            supplierTx.Clear();
            categoryTx.Clear();
            quntity.Value=0;
            priceTx.Clear();
            itemTx2.Clear();
            supplierTx2.Clear();
            categoryTx2.Clear();
            quntity2.Value = 0;
            priceTx2.Clear();
        }
        private void DeleteData()
        {
            //Get the Row index and its value from DataGridView Note: you must add using System.Linq;
            foreach (var cell in from DataGridViewRow row in iGridView.Rows
                                 where row.Selected
                                 from DataGridViewCell cell
                                 in row.Cells
                                 let index = cell.ColumnIndex
                                 where index == 0
                                 select cell)
            {
                //Message Box to confirm The delete of the User
                DialogResult d;
                d = MessageBox.Show("هل انت متاكد من حذف هذه البيانات ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    //Removing Record from The database
                    Program.Con.Open();
                    //string myq = "DBCC CHECKIDENT ('users', RESEED, 0);";
                    String myQuery = "delete from Items where ID = '" + cell.Value + "'";
                    SqlCommand cmd = new SqlCommand(myQuery, Program.Con);
                    //SqlCommand cmd2 = new SqlCommand(myq, Program.Con);
                    cmd.ExecuteNonQuery();
                    //cmd2.ExecuteNonQuery();
                    Program.Con.Close();
                    populate();
                    return;
                }

            }
            MessageBox.Show("الرجاء قم باختيار صف");
        }
        private void UpdateData()
        {
            foreach (var cell in from DataGridViewRow row in iGridView.Rows
                                 where row.Selected
                                 from DataGridViewCell cell in row.Cells
                                 let index = cell.ColumnIndex
                                 where index == 0
                                 select cell)
            {
                DialogResult d;
                d = MessageBox.Show("هل انت متاكد من تعديل هذا البيانات", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    var totalPrice2 = Convert.ToDouble(quntity2.Value) * Convert.ToDouble(priceTx2.Text);

                    var Date2 = System.DateTime.Now.ToString("yyyy.MM.dd");

                    //Updating Value from textbox to the Database
                    Program.Con.Open();
                    SqlCommand cmd = new SqlCommand(
                    "UPDATE Items SET Item='" + itemTx2.Text + "',Supplier='" + supplierTx2.Text + "',Category='" + categoryTx2.Text + "', Quntity='" + quntity2.Value + "', Price='" + priceTx2.Text + "',  TotalPrice='" + totalPrice2 + "', AddedDate='" + Date2 + "'  where ID = '" + cell.Value + "'", Program.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    Program.Con.Close();
                    populate();
                    Clear();
                    return;
                }

            }
            MessageBox.Show("الرجاء قم باختيار صف");
        }
        private void AddData()
        {
            //Calculate the total Value
            var totalPrice = Convert.ToDouble(quntity.Value) * Convert.ToDouble(priceTx.Text);

            //Get The Date from the System
            var Date = System.DateTime.Now.ToString("yyyy.MM.dd");

            //Adding Value from textbox to the Database
            Program.Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Items (Item, Supplier, Category, Quntity, Price, TotalPrice, AddedDate) VALUES('" + itemTx.Text + "','" + supplierTx.Text + "','" + categoryTx.Text + "','"+ quntity.Value+ "','" + priceTx.Text + "','" + totalPrice + "','" + Date + "');", Program.Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تم اضافة المادة بنجاح");
            Program.Con.Close();
            Clear();
            populate();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.GoHome();
            this.Hide();
        }

        private void Itemfrm_Load(object sender, EventArgs e)
        {
            populate();
            iGridView.Columns[iGridView.Columns.Count - 1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            iGridView.Columns[0].HeaderText = "ت";
            iGridView.Columns[0].Width = 25;
            iGridView.Columns[1].HeaderText = "المادة";
            iGridView.Columns[1].Width = 100;
            iGridView.Columns[2].HeaderText = "المصدر";
            iGridView.Columns[2].Width = 100;
            iGridView.Columns[3].HeaderText = "الفئة";
            iGridView.Columns[3].Width = 100;
            iGridView.Columns[4].HeaderText = "الكمية";
            iGridView.Columns[4].Width = 30;
            iGridView.Columns[5].HeaderText = "السعر";
            iGridView.Columns[5].Width = 40;
            iGridView.Columns[6].HeaderText = "السعر الكلي";
            iGridView.Columns[6].Width = 80;
            iGridView.Columns[7].HeaderText = "تاريخ الاضافة";
            iGridView.Columns[7].Width = 60;
            iGridView.Columns[8].HeaderText = "الحالة";
            iGridView.Columns[8].Width = 30;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(itemTx.Text))
            {
                errorProvider1.SetError(itemTx, "الرجاء قم بادخال المادة");
                return;
            }
            else if (String.IsNullOrEmpty(supplierTx.Text))
            {
                errorProvider1.SetError(supplierTx, "الرجاء قم بادخال المصدر");
                return;
            }
            else if (quntity.Value == 0)
            {
                errorProvider1.SetError(quntity, "الرجاء قم بادخال الكمية");
                return;
            }
            else if (String.IsNullOrEmpty(priceTx.Text))
            {
                errorProvider1.SetError(priceTx, "الرجاء قم بادخال السعر");
                return;
            }
            else if (String.IsNullOrEmpty(categoryTx.Text))
            {
                errorProvider1.SetError(categoryTx, "الرجاء قم بادخال الفئة");
                return;
            }
            else
            {
                AddData();
            }
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(itemTx2.Text))
            {
                errorProvider1.SetError(itemTx2, "الرجاء قم بادخال المادة");
                return;
            }
            else if (String.IsNullOrEmpty(supplierTx2.Text))
            {
                errorProvider1.SetError(supplierTx2, "الرجاء قم بادخال المصدر");
                return;
            }
            else if (quntity2.Value == 0)
            {
                errorProvider1.SetError(quntity2, "الرجاء قم بادخال الكمية");
                return;
            }
            else if (String.IsNullOrEmpty(priceTx2.Text))
            {
                errorProvider1.SetError(priceTx2, "الرجاء قم بادخال السعر");
                return;
            }
            else if (String.IsNullOrEmpty(categoryTx2.Text))
            {
                errorProvider1.SetError(categoryTx2, "الرجاء قم بادخال الفئة");
                return;
            }
            else
            {
                UpdateData();
            }
        }

        private void updateBt2_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void addBt2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(itemTx.Text))
            {
                errorProvider1.SetError(itemTx, "الرجاء قم بادخال المادة");
                return;
            }
            else if (String.IsNullOrEmpty(supplierTx.Text))
            {
                errorProvider1.SetError(supplierTx, "الرجاء قم بادخال المصدر");
                return;
            }
            else if (quntity.Value == 0)
            {
                errorProvider1.SetError(quntity, "الرجاء قم بادخال الكمية");
                return;
            }
            else if (String.IsNullOrEmpty(priceTx.Text))
            {
                errorProvider1.SetError(priceTx, "الرجاء قم بادخال السعر");
                return;
            }
            else if (String.IsNullOrEmpty(categoryTx.Text))
            {
                errorProvider1.SetError(categoryTx, "الرجاء قم بادخال الفئة");
                return;
            }
            else
            {
                AddData();
            }
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTx.Text))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * ,CASE WHEN Quntity > 0 THEN 'متوفر' ELSE 'غير متوفر' END AS State FROM Items Where item LIKE '%" + searchTx.Text + "%'"))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.Connection = Program.Con;
                        adapter.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            iGridView.DataSource = dt;
                        }
                    }
                }

            }
            else { MessageBox.Show("ادخل اسم المستخدم في صندوق البحث"); }
        }

        private void itemTx_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(itemTx, "");
        }

        private void quntity_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(quntity, "");
        }

        private void priceTx_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(priceTx, "");
        }

        private void supplierTx_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(supplierTx, "");
        }

        private void categoryTx_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(categoryTx, "");
        }

        private void itemTx2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(itemTx2, "");
        }

        private void quntity2_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(quntity2, "");
        }

        private void priceTx2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(priceTx2, "");
        }

        private void supplierTx2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(supplierTx2, "");
        }

        private void categoryTx2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(categoryTx2, "");
        }
    }
}
