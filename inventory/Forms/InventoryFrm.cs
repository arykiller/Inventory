using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace inventory
{
    public partial class InventoryFrm : Form
    {
        public InventoryFrm()
        {
            InitializeComponent();
        }
        private void Populate()
        {
            using (SqlCommand cmd = new SqlCommand("select Transport.ID, Items.Item, Transport.Quantity, Departments.Department, Buildings.Building from Transport, Items, Departments, Buildings where Transport.ItemID = Items.ID AND Transport.DepID = Departments.ID AND Transport.BuildingID = Buildings.ID;"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.Connection = Program.Con;
                    adapter.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        aGridView.DataSource = dt;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
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
                            aGridView.DataSource = dt;
                        }
                    }
                }

            }
            else { MessageBox.Show("ادخل اسم المستخدم في صندوق البحث"); }
        }
    

        private void InventoryFrm_Load(object sender, EventArgs e)
        {
            Populate();
            aGridView.Columns[0].HeaderText = "ت";
            aGridView.Columns[1].HeaderText = "اسم المادة";
            aGridView.Columns[2].HeaderText = "الكمية";
            aGridView.Columns[3].HeaderText = "القسم";
            aGridView.Columns[4].HeaderText = "البناية";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.GoHome();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < aGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = aGridView.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < aGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < aGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = aGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}
