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
    public partial class Create_Graph : Form
    {

        private Form1 _form;
        public Create_Graph(Form1 form)
        {
            _form = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            /////////////////////////////////////////////////////CONNECTION PART////////////////////////////////////////////////////////////////
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";//online database
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            //////////////////////////////////////////////////Placing all table name in the database to a list///////////////////////////////////
            string tableName = "SELECT * FROM information_schema.tables;";// sql commmand
            var cmdTable = new SqlCommand(tableName, connection);// to check if the name is in the database part
            SqlDataReader reader = cmdTable.ExecuteReader();//reads the schema of the table
            List<string> tableData = new List<string>();//for the tables in the database

            while (reader.Read())//adds all the tables in the list above^^^
            {
                tableData.Add(reader["TABLE_NAME"].ToString());
            }
            reader.Close();//closes reader

            //////////////////////////////////////If statements to check if the table namme exist in the current database////////////////////
            if (tableData.Contains(textBox1.Text))
            {
                MessageBox.Show("Table Name Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.Focus();
            }
            else if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Missing Requirements. Please fill out everything", "Missing Part", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (!tableData.Contains(textBox1.Text))//If not then it will add table
            {
                string graph = comboBox1.Text;
                string creatingGraph = "CREATE TABLE [" + textBox1.Text + "](["+textBox2.Text+"] TEXT,["+textBox3.Text+"] TEXT,"+graph+" TEXT);";// create graph sql string
                var cmd = new SqlCommand(creatingGraph, connection);// creating new table in the database
                cmd.ExecuteNonQuery();//excute above^^

                int i = Form1.i; // this will get the current amount of I in the form1 where I is the number of tables
                i++;//Increment
                TextBox textBox = new TextBox();
                textBox.Text = textBox1.Text;//The name of the table name
                textBox.Name = "textBox" + i.ToString();// The property name of the textbox
                textBox.DoubleClick += _form.TextBox_DoubleClick;
                _form.flowLayoutPanel1.Controls.Add(textBox);// adds the textbox in the flow layout panel in form1
                connection.Close();
                this.Close();
                MessageBox.Show("Table Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Create_Graph_Load(object sender, EventArgs e)
        {

        }
    }
}
