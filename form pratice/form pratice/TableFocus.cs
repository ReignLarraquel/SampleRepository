using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_pratice
{
    public partial class TableFocus : Form
    {
        public TableFocus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 aform = new Form1();
            aform.Show();
            this.Close();
        }
    }
}
