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
    public partial class DeleteRow : Form
    {
        public int i = 0;
        public string[] tableColumnName = new string[100];

        SqlDataAdapter adpt;
        DataTable dt;

        public DeleteRow()
        {
            InitializeComponent();
        }

        private void DeleteRow_Load(object sender, EventArgs e)
        {
            i = 0;
            string tablename = Form1.NameData;
            string columns = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablename + "'ORDER BY ORDINAL_POSITION";
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(columns, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tableColumnName[i] = reader["COLUMN_NAME"].ToString();
                i++;
            }
            reader.Close();
            label2.Text = "Column of: " + tableColumnName[0];

            string getfromcolumn = "SELECT [" + tableColumnName[0] + "] FROM [" + tablename+"]";
            cmd = new SqlCommand(getfromcolumn, connection);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string value = reader[tableColumnName[0]].ToString();
                comboBox1.Items.Add(value);
            }
            reader.Close();
            connection.Close();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            showdata();
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
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != string.Empty)
            { 
                string tablename = Form1.NameData;
                string dltrow = "DELETE FROM " + tablename + " WHERE CONVERT(VARCHAR, [" + tableColumnName[0] + "]) = '" + comboBox1.Text + "'";
                string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(dltrow, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Row hasa been deleted", "Row Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableFocus tfocus = new TableFocus();
                tfocus.Show();
                this.Close();
            }
            else MessageBox.Show("Values Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableFocus tfocus = new TableFocus();
            tfocus.Show();
            this.Close();
        }
    }
}
