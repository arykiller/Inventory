using System;
using System.Windows.Forms;

namespace inventory
{
    public partial class InventoryFrm : Form
    {
        public InventoryFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InventoryFrm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.Back();
            this.Hide();
        }
    }
}
