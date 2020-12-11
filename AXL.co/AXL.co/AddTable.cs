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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Move form:

        private bool mouseDown;
        private Point lastLocation;

        private void AddTable_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AddTable_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void AddTable_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AddTable_Load(object sender, EventArgs e)
        {

        }

        private void createTableBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
