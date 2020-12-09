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
    public partial class ColumnFocus : Form
    {
        SqlDataAdapter adpt;
        DataTable dt;
        public ColumnFocus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // back button
        {
            //TableFocus tfocus = new TableFocus();
            //tfocus.Show();
            this.Close();
        }

        private void ColumnFocus_Load(object sender, EventArgs e)
        {
            //string tablename = Form1.NameData;
            //string connect = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            //SqlConnection connection = new SqlConnection(connect);
            //connection.Open();
            showdata();
        }

        public void showdata()
        {
            string tablename = Form1.NameData;
            string connect = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCB0_tabledata;User Id=DB_A6BCB0_tabledata_admin;Password=marc4lyf";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();
            adpt = new SqlDataAdapter("SELECT * FROM ["+tablename+"]",connection);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
