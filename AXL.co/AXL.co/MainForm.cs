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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void showControl(Control control)
        {
            guna2Panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            guna2Panel1.Controls.Add(control);
        }
        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Graph mm = new Graph();
            showControl(mm);
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
