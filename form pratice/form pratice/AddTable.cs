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

    /*We're no strangers to love
You know the rules and so do I
A full commitment's what I'm thinking of
You wouldn't get this from any other guy

I just wanna tell you how I'm feeling
Gotta make you understand

Never gonna give you up
Never gonna let you down
Never gonna run around and desert you
Never gonna make you cry
Never gonna say goodbye
Never gonna tell a lie and hurt you

We've known each other for so long
Your heart's been aching, but
You're too shy to say it
Inside, we both know what's been going on
We know the game and we're gonna play it

And if you ask me how I'm feeling
Don't tell me you're too blind to see

Never gonna give you up
Never gonna let you down
Never gonna run around and desert you
Never gonna make you cry
Never gonna say goodbye
Never gonna tell a lie and hurt you

Never gonna give you up
Never gonna let you down
Never gonna run around and desert you
Never gonna make you cry
Never gonna say goodbye
Never gonna tell a lie and hurt you

(Ooh, give you up)
(Ooh, give you up)
Never gonna give, never gonna give
(Give you up)
Never gonna give, never gonna give
(Give you up)

We've known each other for so long
Your heart's been aching, but
You're too shy to say it
Inside, we both know what's been going on
We know the game and we're gonna play it

I just wanna tell you how I'm feeling
Gotta make you understand

Never gonna give you up
Never gonna let you down
Never gonna run around and desert you
Never gonna make you cry
Never gonna say goodbye
Never gonna tell a lie and hurt you

Never gonna give you up
Never gonna let you down
Never gonna run around and desert you
Never gonna make you cry
Never gonna say goodbye
Never gonna tell a lie and hurt you

Never gonna give you up
Never gonna let you down
Never gonna run around and desert you
Never gonna make you cry
Never gonna say goodbye
Never gonna tell a lie and hurt you */
    public partial class AddTable : Form
    {
        private Form1 _form;// this is I could have access to the form1 properties
        public AddTable(Form1 form)
        {
            _form = form;// intantiation of this so I could have access to the form1 properties
            InitializeComponent();
        }

        private void AddTable_Load(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string tableName = "SELECT * FROM information_schema.tables;";// sql commmand
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";//online database
            //string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = TestingStuff;Integrated Security = True;";//string for connecting to the local database
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            var cmd1 = new SqlCommand(tableName, connection);
            SqlDataReader reader2 = cmd1.ExecuteReader();
            while (reader2.Read())//TO check if the temp variable is in the table
            {
                if (reader2["TABLE_NAME"].ToString() == "test")// check if the temp variable is in the table
                {
                    string drop = "DROP TABLE test;";//sql command
                    var dropCmd = new SqlCommand(drop, connection);
                    reader2.Close();
                    dropCmd.ExecuteNonQuery();
                    break;
                }
            }
            if (!reader2.IsClosed)//closses reader if reader wasn't closed
            { 
            reader2.Close();          
            }

            string creatingTable = "CREATE TABLE test (Category1 varchar);";//sql command 'test' is a temp name for the table later change
            var cmd = new SqlCommand(creatingTable, connection);// creating new table in the database
            cmd.ExecuteNonQuery();//excute above^^

            var cmdTable = new SqlCommand(tableName, connection);// to check if the name is in the database part
            SqlDataReader reader = cmdTable.ExecuteReader();//reads the schema of the table
            List<string> tableData = new List<string>();//for the tables
            
            while (reader.Read())//adds all the tables in the list above^^^
            {
                tableData.Add(reader["TABLE_NAME"].ToString());
            }
            reader.Close();//closes reader

            if (tableData.Contains(textBox1.Text))//If the table name already exist
            {
                MessageBox.Show("Table Name Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.Focus();
            }
            else if (!tableData.Contains(textBox1.Text)) {  //If not then it will add table
            string queryString = "EXEC sp_rename 'test',@tableName;";// changes the table name to the user desired name
            SqlParameter param1 = new SqlParameter("@tableName", textBox1.Text);
            var command = new SqlCommand(queryString, connection);
            command.Parameters.Add(param1);
            command.ExecuteNonQuery();
                
               
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
    }
}
