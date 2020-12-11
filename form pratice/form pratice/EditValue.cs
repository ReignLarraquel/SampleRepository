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
    public partial class EditValue : Form
    {
        public int i = 0;
        public string[] tableColumnName = new string[100];
        SqlDataAdapter adpt;
        DataTable dt;

        public EditValue()
        {
            InitializeComponent();
        }

        private void EditValue_Load(object sender, EventArgs e)
        {
            i = 0;
            string tablename = Form1.NameData;
            string columns = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablename + "'ORDER BY ORDINAL_POSITION";
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(columns, connection);
            var reader = cmd.ExecuteReader();
            string[] tableColumnName = new string[100];
            while (reader.Read())
            {
                tableColumnName[i] = reader["COLUMN_NAME"].ToString();
                if(tableColumnName[i] != "ID")comboBox1.Items.Add(tableColumnName[i]);
                i++;
            }
            reader.Close();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            showdata();

            string getfromcolumn = "SELECT [ID] FROM " + tablename;
            cmd = new SqlCommand(getfromcolumn, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["ID"].ToString();
                comboBox3.Items.Add(value);
            }
            reader.Close();
            connection.Close();
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //back button
        {
            TableFocus tfocus = new TableFocus();
            tfocus.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != string.Empty && textBox1.Text != string.Empty && comboBox3.Text != string.Empty)
            { 
                string tablename = Form1.NameData;
                string updatevalue = "UPDATE [" + tablename + "] SET [" + comboBox1.Text.ToString() + "] = '" + textBox1.Text.ToString() + "' WHERE CONVERT(VARCHAR,[ID]) = '" + comboBox3.Text.ToString() + "'";
                //string updatevalue = "UPDATE [" + tablename + "] SET [" + comboBox1.Text.ToString() + "] = '" + textBox1.Text.ToString() + "' WHERE CONVERT(VARCHAR,[2]) = '11'";
                string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(updatevalue, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Value has been edited", "Edited value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableFocus tfocus = new TableFocus();
                tfocus.Show();
                this.Close();
            }
            else MessageBox.Show("Values Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
