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
    public partial class DeleteValue : Form
    {
        private static int j = 0;//j is for amount of set of text,panels, and button per value
        private FlowLayoutPanel[] flowLayoutPanels2;// array of flowlayoutpanel
        private Button[] buttons1;//array of buttons
        private TextBox[] textBoxes1;//array of textbox
        private TextBox[] textBoxes2;//array of textbox
        private int amount = 100; // The amount of new values allowed per adding
        private GraphFocus _form;
        public DeleteValue(GraphFocus form)
        {
            _form = form;
            InitializeComponent();
            Panel_Text_Button();
        }
        private void Panel_Text_Button()
        {
            flowLayoutPanels2 = new FlowLayoutPanel[amount];//max amount of flowlayoutpanel
            textBoxes1 = new TextBox[amount];//max amount of textbox
            buttons1 = new Button[amount];//max amount of button
            textBoxes2 = new TextBox[amount];//max amount of button
        }

        private void DeleteValue_Load(object sender, EventArgs e)
        {
            string GraphTableName = Form1.DataName;
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            string tableName = "SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = \'" + GraphTableName + "\';";//check for the COLUMN NAMES of the table
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

            label1.Text = GraphColumnName[0];
            label2.Text = GraphColumnName[1];

            string tablevalues = "SELECT [" + GraphColumnName[0] + "],[" + GraphColumnName[1] + "] FROM \"" + GraphTableName + "\";";
            SqlCommand command2 = new SqlCommand(tablevalues, connection);
            var reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                flowLayoutPanels2[j] = new FlowLayoutPanel();//instanstiation of a new flowlayoutpanel
                flowLayoutPanels2[j].Size = new Size(240, 25);//size of the panel
                flowLayoutPanel1.Controls.Add(flowLayoutPanels2[j]);// adds it to the main panel

                textBoxes1[j] = new TextBox();//instansitation of textboxes1
                textBoxes2[j] = new TextBox();
                flowLayoutPanels2[j].Controls.Add(textBoxes1[j]);//adds
                flowLayoutPanels2[j].Controls.Add(textBoxes2[j]);

                textBoxes1[j].Text = reader2[GraphColumnName[0]].ToString();
                textBoxes2[j].Text = reader2[GraphColumnName[1]].ToString();

                buttons1[j] = new Button();
                buttons1[j].Name = "button" + j.ToString();//buttona name
                buttons1[j].Size = new Size(20, 20);//button size
                buttons1[j].Text = "X";//button text
                buttons1[j].Click += button_Click;// button property when clicked(Delete funtion)
                flowLayoutPanels2[j].Controls.Add(buttons1[j]);//adds it to the panel

                j++;//increment of the amount of sets
            }
            reader2.Close();

            connection.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var remove = (sender as Button).Name;//gets the button name
            string removePanel = remove.Remove(0, 6);//removes the "button" and just gets the number of the button
            flowLayoutPanel1.Controls.Remove(flowLayoutPanels2[int.Parse(removePanel)]);
            j--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string GraphTableName = Form1.DataName;
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            string tableName = "SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = \'" + GraphTableName + "\';";//check for the COLUMN NAMES of the table
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

            string dropTable = "DELETE FROM ["+GraphTableName+"] WHERE "+GraphColumnName[2]+ " IS NULL;";
            var command2 = new SqlCommand(dropTable, connection);
            command2.ExecuteNonQuery();

            bool finish = false;
            for (int n = 0; n < j; n++)
            {
                if (textBoxes1[n].Text == string.Empty || textBoxes2[n].Text == string.Empty) MessageBox.Show("Graph Values must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string insertInto = "INSERT INTO [" + GraphTableName + "] ([" + GraphColumnName[0] + "],[" + GraphColumnName[1] + "]) VALUES (@Xvalues,@Yvalues);";
                    SqlParameter param1 = new SqlParameter("@Xvalues", textBoxes1[n].Text);
                    SqlParameter param2 = new SqlParameter("@Yvalues", textBoxes2[n].Text);
                    SqlCommand cmd = new SqlCommand(insertInto, connection);
                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.ExecuteNonQuery();
                }
                    finish = true;
            }
            if (finish)
            {
                MessageBox.Show("Graph values successfully edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flowLayoutPanel1.Controls.Clear();

                string GRAPHDataName = Form1.DataName;// THIS IS THE TABLE THAT THE USER SELECTED
                _form.chart1.Series[0].Points.Clear();
                string tablevalues = "SELECT [" + GraphColumnName[0] + "],[" + GraphColumnName[1] + "] FROM \"" + GRAPHDataName + "\";";
                SqlCommand command3 = new SqlCommand(tablevalues, connection);
                var reader2 = command3.ExecuteReader();

                _form.chart1.ChartAreas[0].AxisX.Title = GraphColumnName[0];
                _form.chart1.ChartAreas[0].AxisY.Title = GraphColumnName[1];

                while (reader2.Read())
                {
                    string column1 = reader2[GraphColumnName[0]].ToString();
                    string column2 = reader2[GraphColumnName[1]].ToString();
                    _form.chart1.Series[0].Points.AddXY(column1, double.Parse(column2));
                }
                reader2.Close();

                //////////////////////
                j = 0;
                this.Close();
            }

            connection.Close();
        }
    }
}
