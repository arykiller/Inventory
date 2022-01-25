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
    public partial class TransFrm : Form
    {
        public TransFrm()
        {
            InitializeComponent();
        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            Program.Back();
            this.Hide();
        }
    }
}
