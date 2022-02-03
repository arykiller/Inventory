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
    public partial class TransFrm : Form
    {
        public TransFrm()
        {
            InitializeComponent();
        }
        private void TransData()
        {
            foreach (var cell in from DataGridViewRow row in iGridView.Rows
                                 where row.Selected
                                 from DataGridViewCell cell in row.Cells
                                 let index = cell.ColumnIndex
                                 where index == 0
                                 select cell)
            {
                DialogResult d;
                d = MessageBox.Show("هل انت متاكد من تسليم هذه المادة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    Program.Con.Open();
                    //update the Quantity of item when transport to another Dep
                    SqlCommand cmd2 = new SqlCommand("SELECT Quntity FROM Items  where ID = '" + cell.Value + "'", Program.Con);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        var totalQuantity = reader["Quntity"].ToString();
                        var reminingQuantity = Convert.ToInt32(totalQuantity) - Convert.ToInt32(quantity.Value);
                        Program.Con.Close();

                        //transport the data 
                        if(reminingQuantity >= 0)
                        {
                            Program.Con.Open();

                            SqlCommand cmd = new SqlCommand("Insert into Transport values('" + cell.Value + "','" + dep.SelectedValue + "','" + building.SelectedValue + "','" + quantity.Value + "')", Program.Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تم التسليم");
                            Program.Con.Close();


                            Program.Con.Open();
                            SqlCommand command = new SqlCommand(
                            "UPDATE Items SET Quntity='" + reminingQuantity + "'where ID = '" + cell.Value + "'", Program.Con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("لا يوجد كمية كافية للتسليم");                           
                        }
                        reader.Close();
                        Program.Con.Close();
                        Populate();
                        ItemPopulate();
                        return;
                    }
                    return;            
                }
            }
        }
        private void ItemPopulate()
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
        private void Populate()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Transport INNER JOIN Items ON Transport.ItemID = Items.ID INNER JOIN Buildings ON Transport.BuildingID = Buildings.ID INNER JOIN Departments ON Transport.DepID = Departments.ID "))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.Connection = Program.Con;
                    adapter.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        dt.Columns.RemoveAt(1);
                        dt.Columns.RemoveAt(1);
                        dt.Columns.RemoveAt(1);
                        dt.Columns.RemoveAt(2);
                        dt.Columns.RemoveAt(3);
                        dt.Columns.RemoveAt(3);
                        dt.Columns.RemoveAt(3);
                        dt.Columns.RemoveAt(3);
                        dt.Columns.RemoveAt(3);
                        dt.Columns.RemoveAt(3);
                        dt.Columns.RemoveAt(3);
                        dt.Columns.RemoveAt(4);
                        tGridView.DataSource = dt;
                    }
                }
            }

        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            Program.GoHome();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void TransFrm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.Transport' table. You can move, or remove it, as needed.
            this.transportTableAdapter.Fill(this.inventoryDataSet.Transport);
            // TODO: This line of code loads data into the 'inventoryDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.inventoryDataSet.Departments);
            // TODO: This line of code loads data into the 'inventoryDataSet.Buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.inventoryDataSet.Buildings);
            // TODO: This line of code loads data into the 'inventoryDataSet.Buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.inventoryDataSet.Buildings);

            ItemPopulate();
            Populate();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TransData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab.Name == "tabPage3")
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
            else
            {
                if (!string.IsNullOrEmpty(searchTx.Text))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Transport INNER JOIN Items ON Transport.ItemID = Items.ID INNER JOIN Buildings ON Transport.BuildingID = Buildings.ID INNER JOIN Departments ON Transport.DepID = Departments.ID WHERE Item LIKE '%" + searchTx.Text + "%' OR Department LIKE '%" + searchTx.Text + "%' OR Building LIKE '%" + searchTx.Text + "%'"))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            cmd.Connection = Program.Con;
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);
                                dt.Columns.RemoveAt(1);
                                dt.Columns.RemoveAt(1);
                                dt.Columns.RemoveAt(1);
                                dt.Columns.RemoveAt(2);
                                dt.Columns.RemoveAt(3);
                                dt.Columns.RemoveAt(3);
                                dt.Columns.RemoveAt(3);
                                dt.Columns.RemoveAt(3);
                                dt.Columns.RemoveAt(3);
                                dt.Columns.RemoveAt(3);
                                dt.Columns.RemoveAt(3);
                                dt.Columns.RemoveAt(4);
                                tGridView.DataSource = dt;
                            }
                        }
                    }

                }
                else { MessageBox.Show("ادخل اسم المستخدم في صندوق البحث"); }
            }
            
        }

        private void tGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transBt2_Click(object sender, EventArgs e)
        {
            TransData();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
