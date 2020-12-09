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

        SqlDataAdapter adpt;
        DataTable dt;
        public static string NameColumn = "";
        public static int j = 0;
        public int i = 0;
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
            i = 0;
            j = 0;
            button3.Enabled = false;
            string tablename = Form1.NameData;
            string columns = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablename + "'ORDER BY ORDINAL_POSITION";
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            var cmdTable = new SqlCommand(columns, connection);
            SqlDataReader reader = cmdTable.ExecuteReader();
            while (reader.Read())
            {
                textBoxes1[j] = new TextBox();
                textBoxes1[j].Text = reader["COLUMN_NAME"].ToString();
                textBoxes1[j].Name = "txt_" + j + 1.ToString();
                textBoxes1[j].Size = new System.Drawing.Size(140, 20);
                textBoxes1[j].ReadOnly = true;
                ColumnPanel.Controls.Add(textBoxes1[j]);
                textBoxes1[j].DoubleClick += new System.EventHandler(this.columnDC);
                j++;

                Button button = new Button();
                button.Size = new System.Drawing.Size(20, 20);
                button.Name = "btnDelete_" + (j);
                button.Text = "X";
                button.Click += new System.EventHandler(this.sqlbtnDelete_Click);
                DltBtnPanel.Controls.Add(button);
            }
            reader.Close();
            connection.Close();
            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBoxes1[j] = new TextBox();

            textBoxes1[j].Size = new System.Drawing.Size(140, 20);
            textBoxes1[j].Name = "txt_" + (j + 1);


            ColumnPanel.Controls.Add(textBoxes1[j]); // adds the textbox to the panel
            textBoxes1[j].DoubleClick += new System.EventHandler(this.columnDC);
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

        public void columnDC(object sender, EventArgs e)
        {
            ColumnFocus cFocus = new ColumnFocus();
            TextBox textBoxes = (sender as TextBox);
            var text = (sender as TextBox).Text;
            string tablename = Form1.NameData;
            NameColumn = text.ToString();
            ColumnPanel.Refresh();
            DltBtnPanel.Refresh();
            showdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button); //Reference the Button which was clicked.
            int index = int.Parse(button.Name.Split('_')[1]); //Determine the Index of the Button.
            string columnname = textBoxes1[index].Text;
            ColumnPanel.Controls.Remove(ColumnPanel.Controls.Find(textBoxes1[index].Name, true)[0]); //Find the TextBox using Index and remove it.
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
            dltcolumn.ExecuteReader();
            ColumnPanel.Controls.Remove(ColumnPanel.Controls.Find(textBoxes1[index - 1].Name, true)[0]); //Find the TextBox using Index and remove it.

            DltBtnPanel.Controls.Remove(button); //Remove the Button.
            j--;
            connection.Close();//closses connection
            ColumnPanel.Refresh();
            DltBtnPanel.Refresh();
            showdata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tablename = Form1.NameData;
            string connect = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();

            string columns = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablename + "'ORDER BY ORDINAL_POSITION";
            SqlCommand cmd = new SqlCommand(columns, connection);
            var reader = cmd.ExecuteReader();
            string[] tableColumnName = new string[100];
            while (reader.Read())
            {
                tableColumnName[i] = reader["COLUMN_NAME"].ToString();
                i++;
            }
            reader.Close();
            bool finish = false;
            for (int n = i; n < j; n++)
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
                MessageBox.Show("Columns successfully added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                j = 0;
                ColumnPanel.Refresh();
                DltBtnPanel.Refresh();
                showdata();
            }
        }
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

        private void button4_Click(object sender, EventArgs e)
        {
            string tablename = Form1.NameData;
            string connect = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();

            string columns = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablename + "'ORDER BY ORDINAL_POSITION";
            SqlCommand cmd = new SqlCommand(columns, connection);
            var reader = cmd.ExecuteReader();
            string[] tableColumnName = new string[100];
            while (reader.Read())
            {
                tableColumnName[i] = reader["COLUMN_NAME"].ToString();
                i++;
            }
            reader.Close();
            for (int c = 0; c <= dataGridView1.Rows.Count-1; c++)
            {
                for (int r = 0; r <= i - 2; r++)
                {
                    string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
                    SqlConnection con = new SqlConnection(connectionString);
                    string addvalues = "INSERT INTO [" + tablename + "] ([" + textBoxes1[r].Text + "]) VALUES ('" + dataGridView1.Rows[c].Cells[r].Value + "')";
                    SqlCommand command = new SqlCommand(addvalues, connection);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Values successfully added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            showdata();
        }
    }
}   
    
