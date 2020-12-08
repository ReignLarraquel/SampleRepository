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
namespace form_pratice
{ 
    public partial class TableFocus : Form
    {
        public static int j = 0;
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

        private void TableFocus_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // a button to add a new column

            TextBox textbox1 = new TextBox(); // creates a new() for textbox (for Categoryname)
            TextBox textbox2 = new TextBox(); // creates a new() for textbox (for Values)

            int count = ColumnPanel.Controls.OfType<TextBox>().ToList().Count; // counts the textboxes in categorypanel
            int count1 = ValuesPanel.Controls.OfType<TextBox>().ToList().Count; // counts the textboxes in valuespanel

            textbox1.Size = new System.Drawing.Size(140, 20);
            textbox2.Size = new System.Drawing.Size(200, 20);

            if (count >= j)
            {
            textbox1.Name = "txt_" + (count + 1); // name of the textbox when created
            textbox2.Name = "txtValue_" + (count1 + 1);
            }
            else if (j > count)
            {
                textbox1.Name = "txt_" + (j + 1);
                textbox2.Name = "txtValue_" + (j + 1);
            }

            ColumnPanel.Controls.Add(textbox1); // adds the textbox to the panel
            ValuesPanel.Controls.Add(textbox2);

            j++;

            //textbox1.Text = textbox1.Name;
            //textbox2.Text = textbox2.Name;

            Button button = new Button();
            button.Size = new System.Drawing.Size(20, 20);

            if (count >= j)
            {
                button.Name = "btnDelete_" + (count+1);
            }
            else if (j > count)
            {
                button.Name = "btnDelete_" + (j);
            }
            button.Text = "X";
            button.Click += new System.EventHandler(this.btnDelete_Click);
            DltBtnPanel.Controls.Add(button);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button); //Reference the Button which was clicked.

            int index = int.Parse(button.Name.Split('_')[1]); //Determine the Index of the Button.

            ColumnPanel.Controls.Remove(ColumnPanel.Controls.Find("txt_" + index, true)[0]); //Find the TextBox using Index and remove it.
            ValuesPanel.Controls.Remove(ValuesPanel.Controls.Find("txtValue_" + index, true)[0]);

            DltBtnPanel.Controls.Remove(button); //Remove the Button.

            foreach (Button btn in DltBtnPanel.Controls.OfType<Button>()) 
            {
                int controlIndex = int.Parse(btn.Name.Split('_')[1]); 
                if (controlIndex > index) //Rearranging the Location controls.
                {
                    TextBox txt = (TextBox)ColumnPanel.Controls.Find("txt_" + controlIndex, true)[0];
                    TextBox txt1 = (TextBox)ValuesPanel.Controls.Find("txtValue_" + controlIndex, true)[0];
                    btn.Top = btn.Top - 25;
                    txt.Top = txt.Top - 25;
                    txt1.Top = txt1.Top - 25;
                }
            }
            ColumnPanel.Refresh();
            ValuesPanel.Refresh();
            DltBtnPanel.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            string tablename = Form1.NameData;
            int valuestablenum = int.Parse(textbox2.Name.Split('_')[1]);
            TextBox txt = (TextBox)ColumnPanel.Controls.Find("txt_" + valuestablenum, true)[0];
            string connect = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();
            foreach (TextBox bx in ColumnPanel.Controls.OfType<TextBox>())
            {
                string columnName = textbox1.Text;
                string valuesName = textbox2.Text;
                string tableInsert = "ALTER TABLE " + tablename + " ADD " + columnName +" TEXT;";
            }
            connection.Close();
            */
        }
    }
}