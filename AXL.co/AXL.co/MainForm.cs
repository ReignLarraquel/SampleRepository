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
            MainMenu mm = new MainMenu();
            showControl(mm);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip1.Show("Overview", guna2CircleButton1);
        }

        private void guna2HtmlToolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        private void guna2CircleButton2_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip2.Show("Tables", guna2CircleButton2);
        }

        private void guna2CircleButton3_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip3.Show("Graphs", guna2CircleButton3);
        }

        private void guna2CircleButton4_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip4.Show("Flowcharts", guna2CircleButton4);
        }

        private void guna2CircleButton6_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip5.Show("Information", guna2CircleButton6);
        }

        private void guna2CircleButton5_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip6.Show("Exit", guna2CircleButton5);
        }
    }
}
