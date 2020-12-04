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

namespace GraphTables
{
    public partial class Form1 : Form
    {
        public static int i = 0;// this is for the number of text box
        public static string DataName = "";//This is so I could get the tablename of what the user selected
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rename_Graph aform = new Rename_Graph(this);
            aform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Graph aform = new Create_Graph(this);
            aform.Show();// open the Create Graph form
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tableName = "SELECT * FROM information_schema.tables;";// sql commmand
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            var cmdTable = new SqlCommand(tableName, connection);
            SqlDataReader reader = cmdTable.ExecuteReader();//reads the schema of the table

            while (reader.Read())//Puts the name of the tables in the database and adds a textbox in the flow panel
            {
                i++;
                TextBox textBox = new TextBox();
                textBox.Text = reader["Table_Name"].ToString();//The text inside the textbox
                textBox.Name = "textBox" + i.ToString();// The property name of the textbox
                textBox.DoubleClick += TextBox_DoubleClick;//Add a property to the textbox
                flowLayoutPanel1.Controls.Add(textBox);// adds the textbox in the flow layout panel
            }
            reader.Close();//closes reader
            connection.Close();//closses connection

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_Graph aform = new Delete_Graph(this);
            aform.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        public void TextBox_DoubleClick(object sender, EventArgs e)
        {
            GraphFocus aform = new GraphFocus();
            var text = (sender as TextBox).Text;//Gets what was double clicked
            DataName = text.ToString();//Saves the thing that was double clicked
            aform.Show();
            this.Hide();
        }

    }
}
