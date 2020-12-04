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
    public partial class Delete_Graph : Form
    {
        private Form1 _form;// this is I could have access to the form1 properties
        public Delete_Graph(Form1 form)
        {
            _form = form;// intantiation of this so I could have access to the form1 properties
            InitializeComponent();
        }

        private void Delete_Graph_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";//online database
            //string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = TestingStuff;Integrated Security = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString = "SELECT * FROM information_schema.tables;";
            SqlCommand command = new SqlCommand(queryString, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string tableName = reader["TABLE_NAME"].ToString();
                comboBox1.Items.Add(tableName);
            }
            reader.Close();
            connection.Close();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tableName = "SELECT * FROM information_schema.tables;";
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";//online database
            //string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = TestingStuff;Integrated Security = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("No table Selected. Select a Table to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string DeleteQueryString = "DROP TABLE [" + comboBox1.SelectedItem.ToString() + "];"; //String query to delete the table
                SqlCommand command = new SqlCommand(DeleteQueryString, connection);
                command.ExecuteNonQuery();
                // This part basically refresh the flowlayoutpanel1 in form1
                var cmdTable2 = new SqlCommand(tableName, connection);
                SqlDataReader reader2 = cmdTable2.ExecuteReader();//reads the schema of the table
                int i = Form1.i;
                _form.flowLayoutPanel1.Controls.Clear();//removes all current things in the flowlayout panel
                while (reader2.Read())//Puts the name of the tables in the database and adds a textbox in the flow panel
                {
                    i++;
                    TextBox textBox = new TextBox();
                    textBox.Text = reader2["Table_Name"].ToString();//The text inside the textbox
                    textBox.Name = "textBox" + i.ToString();// The property name of the textbox
                    _form.flowLayoutPanel1.Controls.Add(textBox);// adds the textbox in the flow layout panel
                }
                reader2.Close();
                this.Close();
                MessageBox.Show("Table Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }
    }
}
