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
        private TextBox[] textBoxes1; //array of textbox
        private int amount = 100; // The amount of new values allowed per adding

        public TableFocus()
        {
            InitializeComponent();
            Panel_Text_Button();
        }

        private void Panel_Text_Button()
        {
            textBoxes1 = new TextBox[amount];//max amount of textbox
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

            textBoxes1[j] = new TextBox();

            int count = ColumnPanel.Controls.OfType<TextBox>().ToList().Count; // counts the textboxes in categorypanel

            textBoxes1[j].Size = new System.Drawing.Size(140, 20);

            if (count >= j)
            {
                textBoxes1[j].Name = "txt_" + (count + 1); // name of the textbox when created
            }
            else if (j > count)
            {
                textBoxes1[j].Name = "txt_" + (j + 1);
            }

            ColumnPanel.Controls.Add(textBoxes1[j]); // adds the textbox to the panel

            j++;

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

            DltBtnPanel.Controls.Remove(button); //Remove the Button.

            foreach (Button btn in DltBtnPanel.Controls.OfType<Button>()) 
            {
                int controlIndex = int.Parse(btn.Name.Split('_')[1]); 
                if (controlIndex > index) //Rearranging the Location controls.
                {
                    TextBox txt = (TextBox)ColumnPanel.Controls.Find("txt_" + controlIndex, true)[0];
                    btn.Top = btn.Top - 25;
                    txt.Top = txt.Top - 25;
                }
            }
            j--;
            ColumnPanel.Refresh();
            DltBtnPanel.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tablename = Form1.NameData;
            string connect = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();



            bool finish = false;
            for (int n = 0; n < j; n++)
            {
                if (textBoxes1[n].Text == string.Empty) MessageBox.Show("Values must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string alterTable = "ALTER TABLE [" + tablename + "] ADD [" + textBoxes1[n].Text + "] TEXT";
                    SqlParameter param1 = new SqlParameter(tablename, textBoxes1[n].Text);
                    SqlCommand command = new SqlCommand(alterTable, connection);
                    command.Parameters.Add(param1);
                    command.ExecuteNonQuery();
                    finish = true;
                }
            }
            if (finish)
            {
                MessageBox.Show("Columns and Values successfully added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ColumnPanel.Controls.Clear();
                DltBtnPanel.Controls.Clear();
            }
            connection.Close();
            j = 0;
        }
    }
}