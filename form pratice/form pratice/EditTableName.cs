using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace form_pratice
{
    public partial class EditTableName : Form
    {
        private Form1 _form;// this is I could have access to the form1 properties
        public EditTableName(Form1 form)
        {
            _form = form;// intantiation of this so I could have access to the form1 properties
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";//online database
            //string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = TestingStuff;Integrated Security = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string tableName = "SELECT * FROM information_schema.tables;";
            var cmdTable = new SqlCommand(tableName, connection);// to check if the name is in the database part
            SqlDataReader reader = cmdTable.ExecuteReader();//reads the schema of the table
            List<string> tableData = new List<string>();//for the tables

            while (reader.Read())//adds all the tables in the list above^^^
            {
                tableData.Add(reader["TABLE_NAME"].ToString());
            }
            reader.Close();//closes reader

            if (comboBox1.SelectedIndex.ToString() == string.Empty || textBox1.Text == string.Empty)
            {
                MessageBox.Show("Table name required or edit name is empty" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tableData.Contains(textBox1.Text))//If the table name already exist
            {
                MessageBox.Show("Table Name Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.Focus();
            }
            else if (!tableData.Contains(textBox1.Text))
            {
                string queryString = "EXEC sp_rename @currentTableName,@tableName;";// changes the table name to the user desired name
                SqlParameter param1 = new SqlParameter("@tableName", textBox1.Text);//parameter for the change name
                SqlParameter param2 = new SqlParameter("@currentTableName", comboBox1.SelectedItem.ToString());//parameter for the desired change
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add(param1);
                command.Parameters.Add(param2);
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
                    textBox.DoubleClick += _form.TextBox_DoubleClick;
                    _form.flowLayoutPanel1.Controls.Add(textBox);// adds the textbox in the flow layout panel
                }
                reader.Close();//closes reader
                this.Close();
                MessageBox.Show("Table name edited", "edited name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                connection.Close();
        }

        private void EditTableName_Load(object sender, EventArgs e)
        {
            //This whole part basically adds all the table names in the combobox
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";//online database
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
