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
        public string columnname = ""; //a string to handle all columnnames
        public string valuesname = ""; // string to handle all values
        public string text = "";

        SqlDataAdapter adpt;
        DataTable dt;

        public static string NameColumn = "";

        public static int j = 0; // count of all recently added columns
        public int i = 0; // count of all columns
        public int ix1 = 0; // max count of all columns (for the input)
        public int k = 0; // for unique columns

        public TextBox[] textBoxes1; //array of textbox
        public TextBox[] textBoxes2;

        private int amount = 100; // The amount of new values allowed per adding

        public TableFocus()
        {
            InitializeComponent();
            Panel_Text_Button();
        }

        private void Panel_Text_Button()
        {
            textBoxes1 = new TextBox[amount];//max amount of textbox
            textBoxes2 = new TextBox[amount];//max amount of textbox
        }


        private void button1_Click(object sender, EventArgs e) // goes back
        {
            Form1 aform = new Form1();
            aform.Show();
            this.Close();
        }

        private void TableFocus_Load(object sender, EventArgs e) 
        { // when loading it sets everything ready for the user mostly for loading up their previous columns
            i = 0; // resets all values
            ix1 = 0;
            j = 0;
            button3.Enabled = false;
            string tablename = Form1.NameData;
            string columns = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablename + "'ORDER BY ORDINAL_POSITION";
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            var cmdTable = new SqlCommand(columns, connection);
            SqlDataReader reader = cmdTable.ExecuteReader();
            while (reader.Read()) // adds the columns in the right areas
            {
                textBoxes1[j] = new TextBox();
                textBoxes1[j].Text = reader["COLUMN_NAME"].ToString();
                textBoxes1[j].Name = "txt_" + (j + 1).ToString();
                textBoxes1[j].Size = new System.Drawing.Size(140, 20);
                textBoxes1[j].ReadOnly = true; // makes ID not usable
                if (textBoxes1[j].Name == "txt_1") textBoxes1[j].Enabled = false;
                ColumnPanel.Controls.Add(textBoxes1[j]);
                textBoxes1[j].DoubleClick += new System.EventHandler(this.columnDC);
                textBoxes2[j] = new TextBox();
                textBoxes2[j].Name = "txtvalue_" + (j + 1).ToString();
                textBoxes2[j].Size = new System.Drawing.Size(200, 20);
                if (textBoxes2[j].Name == "txtvalue_1") textBoxes2[j].Enabled = false; //makes ID values not usable
                ValuesPanel.Controls.Add(textBoxes2[j]);
                j++;
                Button button = new Button();
                button.Size = new System.Drawing.Size(20, 20);
                button.Name = "btnDelete_" + (j);
                button.Text = "X";
                button.Click += new System.EventHandler(this.sqlbtnDelete_Click);
                if (button.Name == "btnDelete_1") button.Enabled = false; // makes the ID delete button not usable
                DltBtnPanel.Controls.Add(button);
            }
            reader.Close();
            showdata();

            SqlCommand cmd = new SqlCommand(columns, connection);
            var reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                ix1++;
            }
            reader2.Close();

            var reader3 = cmd.ExecuteReader();
            string[] tableColumnName = new string[100];
            while (reader3.Read())
            {
                if (i == ix1-1)
                {
                    tableColumnName[i] = reader3["COLUMN_NAME"].ToString();
                    columnname += "[" + tableColumnName[i] + "]";
                    i++;
                }
                if (i < ix1)
                {
                    tableColumnName[i] = reader3["COLUMN_NAME"].ToString();
                    columnname += "[" + tableColumnName[i] + "],";
                    i++;
                    if (columnname == "[ID],") columnname = "";
                }
            }
            reader3.Close();
            connection.Close();

        }
        // a button to add a textbox and a delete textbox button
        private void button2_Click(object sender, EventArgs e)
        {

            textBoxes1[j] = new TextBox();

            textBoxes1[j].Size = new System.Drawing.Size(140, 20);
            textBoxes1[j].Name = "txt_" + (j + 1);

            ColumnPanel.Controls.Add(textBoxes1[j]); // adds the textbox to the panel
            textBoxes1[j].DoubleClick += new System.EventHandler(this.columnDC);

            textBoxes2[j] = new TextBox();
            textBoxes2[j].Name = "txtvalue_" + (j + 1).ToString();
            textBoxes2[j].Size = new System.Drawing.Size(200, 20);
            ValuesPanel.Controls.Add(textBoxes2[j]);

            j++;
            button3.Enabled = true;

            Button button = new Button();
            button.Size = new System.Drawing.Size(20, 20);
            button.Name = "btnDelete_" + (j - 1);
            button.Text = "X";
            button.Click += new System.EventHandler(this.btnDelete_Click);
            DltBtnPanel.Controls.Add(button);

            ColumnPanel.Refresh();
            DltBtnPanel.Refresh();
        }


        //a func on when a column is double clicked
        public void columnDC(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button); //Reference the Button which was clicked.
            int index = int.Parse(button.Name.Split('_')[1]); //Determine the Index of the Button.
            string columnname = textBoxes1[index].Text;
            ColumnPanel.Controls.Remove(ColumnPanel.Controls.Find(textBoxes1[index].Name, true)[0]); //Find the TextBox using Index and remove it.
            ValuesPanel.Controls.Remove(ValuesPanel.Controls.Find(textBoxes2[index].Name, true)[0]);
            DltBtnPanel.Controls.Remove(button); //Remove the Button.
            j--;
            ColumnPanel.Refresh();
            DltBtnPanel.Refresh();
        }

        private void sqlbtnDelete_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button); //Reference the Button which was clicked.
            int index = int.Parse(button.Name.Split('_')[1]); //Determine the Index of the Button.
            string columnname = textBoxes1[index - 1].Text;
            string tablename = Form1.NameData;
            string columnsdlt = "ALTER TABLE [" + tablename + "] DROP COLUMN [" + columnname + "]";
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open
            var dltcolumn = new SqlCommand(columnsdlt, connection);
            ColumnPanel.Controls.Remove(ColumnPanel.Controls.Find(textBoxes1[index-1].Name, true)[0]); //Find the TextBox using Index and remove it.
            ValuesPanel.Controls.Remove(ValuesPanel.Controls.Find(textBoxes2[index-1].Name, true)[0]);
            DltBtnPanel.Controls.Remove(button); //Remove the Button.
            i = 0;
            j--;
            dltcolumn.ExecuteReader();
            connection.Close();//closes connection

            //refresh the data stored inside
            ColumnPanel.Refresh();
            DltBtnPanel.Refresh();

            //shows data in gridview
            showdata();
        }

        private void button3_Click(object sender, EventArgs e) // adds a column in the database
        {
            i = 0;
            ix1 = 0;
            string tablename = Form1.NameData;
            string columns = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablename + "'ORDER BY ORDINAL_POSITION";
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(columns, connection);
            string[] tableColumnName = new string[100];
            var reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                ix1++;
            }
            reader2.Close();

            var reader3 = cmd.ExecuteReader();
            while (reader3.Read())
            {
                if (i == ix1 - 1)
                {
                    tableColumnName[i] = reader3["COLUMN_NAME"].ToString();
                    columnname += "[" + tableColumnName[i] + "]";
                    i++;
                }
                if (i < ix1)
                {
                    tableColumnName[i] = reader3["COLUMN_NAME"].ToString();
                    columnname += "[" + tableColumnName[i] + "],";
                    if (columnname == "[ID],") columnname = "";
                    i++;
                }
            }
            reader3.Close();

            bool finish = false;
            //adds in the column where it starts right after i(the count of the already added columns)
            bool check = false;
            for (int n = i; n < j; n++)
            {
                reader3 = cmd.ExecuteReader();
                while (reader3.Read())
                {
                    if (k == ix1 - 1)
                    {
                        tableColumnName[k] = reader3["COLUMN_NAME"].ToString();
                        text = tableColumnName[k].ToString();
                        if (textBoxes1[n].Text == text) MessageBox.Show("Columns must have unique names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); check = false;
                        if (textBoxes1[n].Text != text) check = true;
                        i++;
                    }
                    if (k < ix1)
                    {
                        tableColumnName[k] = reader3["COLUMN_NAME"].ToString();
                        text = tableColumnName[k].ToString();
                        if (textBoxes1[n].Text == text) MessageBox.Show("Columns must have unique names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); check = false;
                        if(textBoxes1[n].Text != text) check = true;
                        i++;
                    }
                }
                reader3.Close();
                if (textBoxes1[n].Text == string.Empty) MessageBox.Show("Columns must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (check)
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
                connection.Close();
                MessageBox.Show("Columns successfully added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableFocus tfocus = new TableFocus();
                tfocus.Show();
                this.Close();
            }
        }
        // a func to show data in the gridview
        public void showdata() 
        {
            string tablename = Form1.NameData;
            string connect = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();
            adpt = new SqlDataAdapter("SELECT * FROM [" + tablename + "]", connection);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        // a button to save data written in the gridview to be placed in the database

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            valuesname = "";
            bool finished = false;
            i = 0;
            string tablename = Form1.NameData;
            string connect = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();


            if (textBoxes2[2].Text != string.Empty) 
            {
                for (int c = 0; c < ix1; c++)
                {
                    if (i == ix1 - 1)
                    {
                        valuesname += "'" + textBoxes2[i].Text + "'";
                        i++;
                        finished = true;
                    }
                    if (i < ix1)
                    {
                        valuesname += "'" + textBoxes2[i].Text + "',";
                        if (valuesname == "'" + textBoxes2[0].Text + "',") valuesname = "";
                        i++;
                    }
                }
                if (finished)
                {
                    string addvalues = "INSERT INTO [" + tablename + "] (" + columnname + ") VALUES (" + valuesname + ")";
                    SqlCommand command = new SqlCommand(addvalues, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Values successfully added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    TableFocus tfocus = new TableFocus();
                    tfocus.Show(); 
                    this.Close();
                }
            }
            else MessageBox.Show("Value1 must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ValuesPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) // edit button
        {
            EditValue aform = new EditValue();
            aform.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e) // delete button
        {
            DeleteRow aform = new DeleteRow();
            aform.Show();
            this.Close();
        }
    }
}   
    
