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
    public partial class GraphFocus : Form
    {
        public GraphFocus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 aform = new Form1();
            aform.Show();
            this.Close();
        }

        private void GraphFocus_Load(object sender, EventArgs e)
        {
            string GRAPHDataName = Form1.DataName;// THIS IS THE TABLE THAT THE USER SELECTED
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open


            string tableName = "SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + GRAPHDataName + "';";//check for the COLUMN NAMES of the table
            SqlCommand command = new SqlCommand(tableName, connection);
            var reader = command.ExecuteReader();

            string[] GraphColumnName = new string[3];// AN ARRAY
            int i = 0;
            while (reader.Read())// READS ALL THE COLUMN NAME AND SAVES IT ON AN ARRAY
            {
                GraphColumnName[i] = reader["COLUMN_NAME"].ToString();
                i++;
            }
            reader.Close();

            if (GraphColumnName[2] == "Line") chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            else if (GraphColumnName[2] == "Bar") chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            else if (GraphColumnName[2] == "Column") chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            else if (GraphColumnName[2] == "Pie") chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;


            //string tablevalues = "SELECT "+ GraphColumnName+ ","+ GraphColumnName + " FROM " + GRAPHDataName + ";";
            string tablevalues = "SELECT ["+GraphColumnName[0]+"],["+GraphColumnName[1]+"] FROM ["+GRAPHDataName+"];";
            SqlCommand command2 = new SqlCommand(tablevalues, connection);
            var reader2 = command2.ExecuteReader();

            chart1.ChartAreas[0].AxisX.Title = GraphColumnName[0];
            chart1.ChartAreas[0].AxisY.Title = GraphColumnName[1];
            while (reader2.Read())
            {
                string column1 = reader2[GraphColumnName[0]].ToString();
                string column2 = reader2[GraphColumnName[1]].ToString();
                chart1.Series[0].Points.AddXY(column1,double.Parse(column2));
            }
            reader2.Close();

            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddValue aform = new AddValue(this);
            aform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteValue aform = new DeleteValue(this);
            aform.Show();
        }
    }
}
