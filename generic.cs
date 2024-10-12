using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT_Magui_Anca
{
    public partial class generic : Form
    {
        public generic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.ShowDialog();
            this.Close();
            this.Visible = false;
            x.ShowDialog();
        }

        private void generic_Load(object sender, EventArgs e)
        {

        }
    }
}
