using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AXL.co
{
    public partial class AddTable : Form
    {
        public AddTable()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            frontPage.Visible = false;
            secondPage.Visible = true;
        }
    }
}
