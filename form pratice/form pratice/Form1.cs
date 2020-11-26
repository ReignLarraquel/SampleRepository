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
    public partial class Form1 : Form
    {
        public static int i = 0;// this is for the number of textbox

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tableName = "SELECT * FROM information_schema.tables;";// sql commmand

            string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = TestingStuff;Integrated Security = True;";//string for connecting to the local database
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
                flowLayoutPanel1.Controls.Add(textBox);// adds the textbox in the flow layout panel
            }
            reader.Close();//closes reader
            connection.Close();//closses connection
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTable aform = new AddTable(this);
            aform.Show();// open the AddTable form
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditTableName aform = new EditTableName(this);
            aform.Show();// open EditTableName form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteTable aform = new DeleteTable(this);
            aform.Show();
        }
    }
}
