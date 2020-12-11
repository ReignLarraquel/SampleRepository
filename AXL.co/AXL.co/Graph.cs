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
using Guna.UI2.WinForms;

namespace AXL.co
{
    public partial class Graph : UserControl
    {
        private int j = 0;//j is for amount of set of text,panels, and button per value
        private int r = 0;//amount of rows per edit graph values
        private FlowLayoutPanel[] flowLayoutPanels2;
        private Button[] buttons1;//array of buttons
        private TextBox[] textBoxes1;//array of textbox
        private TextBox[] textBoxes2;//array of textbox
        private Guna2GradientPanel[] GradientPanels;
        private Guna2Panel[] panels;
        private Label[] labels;
        private Label[] labels2;
        private Label[] labels3;
        private Guna2CircleButton[] CircleButtons;
        private Guna2PictureBox[] PictureBoxes;
        private int amount = 100; // The amount of new values allowed per adding
        private string[] GraphColumnName = new string[3];//for the Graph column names
        private int pressed = 0;//when the panel where the data graphname is pressed
        private int lastClicked;//the last clicked ^^^
        private int graphCount = 0;//counts how many graph
        private int editNameGraph = 0;//How many times edit graph was clicked
        private string currentllySeletedGraph = ""; //currently selected graph
        private int currentJ= 0;//current number of J that is being selected
        public Graph()
        {
            InitializeComponent();
            Dynamics();
        }

        private void Dynamics()
        {
            GradientPanels = new Guna2GradientPanel[amount];
            panels = new Guna2Panel[amount];
            labels = new Label[amount];
            labels2 = new Label[amount];
            labels3 = new Label[amount];
            CircleButtons = new Guna2CircleButton[amount];
            PictureBoxes = new Guna2PictureBox[amount];
            flowLayoutPanels2 = new FlowLayoutPanel[amount];//max amount of flowlayoutpanel
            textBoxes1 = new TextBox[amount];//max amount of textbox
            buttons1 = new Button[amount];//max amount of button
            textBoxes2 = new TextBox[amount];//max amount of button
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Graph_Count()
        {
            graphsCount.Text = "Graphs [" + graphCount.ToString() + "]";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Graph_Load(object sender, EventArgs e)
        {
            guna2CircleButton1.Hide();
            guna2CircleButton2.Hide();
            editGraph.Enabled = false;
            string tableName = "SELECT * FROM information_schema.tables;";// sql commmand
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            var cmdTable = new SqlCommand(tableName, connection);
            SqlDataReader reader = cmdTable.ExecuteReader();//reads the schema of the table
            
            while (reader.Read())//Puts the name of the tables in the database and adds a textbox in the flow panel
            {
                GraphColumn(reader["Table_Name"].ToString());//Method to get column name
                //instantiation
                GradientPanels[j] = new Guna2GradientPanel();
                panels[j] = new Guna2Panel();
                labels[j] = new Label();
                labels2[j] = new Label();
                labels3[j] = new Label();
                CircleButtons[j] = new Guna2CircleButton();
                PictureBoxes[j] = new Guna2PictureBox();
                //pannels
                GradientPanels[j].Size = new Size(920, 58);
                GradientPanels[j].FillColor = Color.CornflowerBlue;//color gradiant
                panels[j].Cursor = Cursors.Hand;
                panels[j].Size = new Size(908, 58);
                panels[j].Name = j.ToString() + ","+ reader["Table_Name"].ToString();
                panels[j].BackColor = Color.FromArgb(30, 30, 30);
                panels[j].DoubleClick += Panel_Click;
                flowLayoutPanel1.Controls.Add(GradientPanels[j]);
                GradientPanels[j].Controls.Add(panels[j]);
                panels[j].Location = new Point(13, 0);
                //1st Label the Graph name
                labels[j].Text = reader["Table_Name"].ToString();
                labels[j].Font = new Font("Microsoft Sans Serif", 11,FontStyle.Regular);
                labels[j].ForeColor = System.Drawing.Color.White;
                panels[j].Controls.Add(labels[j]);
                labels[j].Location = new Point(57, 19);
                //2nd label the X graph name
                labels2[j].Text = GraphColumnName[0];
                labels2[j].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                labels2[j].ForeColor = System.Drawing.Color.White;
                panels[j].Controls.Add(labels2[j]);
                labels2[j].Location = new Point(555, 20);
                //3rd labe the Y graph name
                labels3[j].Text = GraphColumnName[1];
                labels3[j].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                labels3[j].ForeColor = System.Drawing.Color.White;
                panels[j].Controls.Add(labels3[j]);
                labels3[j].Location = new Point(746, 20);
                //delete button
                CircleButtons[j].Text = "X";
                CircleButtons[j].ForeColor = System.Drawing.Color.Red;
                CircleButtons[j].Name = j.ToString() + "," + reader["Table_Name"].ToString();
                CircleButtons[j].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                CircleButtons[j].Size = new Size(46, 50);
                CircleButtons[j].FillColor = Color.Transparent;
                panels[j].Controls.Add(CircleButtons[j]);
                CircleButtons[j].Location = new Point(851, 6);
                CircleButtons[j].Click += Delete_Button;

                graphCount++;
                Graph_Count();
                j++;
            }
            reader.Close();//closes reader
            connection.Close();//closses connection
        }

        public void GraphColumn(string temp)
        {
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            string tableName = "SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = \'" + temp + "\';";//check for the COLUMN NAMES of the table
            SqlCommand command = new SqlCommand(tableName, connection);
            var reader = command.ExecuteReader();

            int i = 0;
            while (reader.Read())// READS ALL THE COLUMN NAME AND SAVES IT ON AN ARRAY
            {
                GraphColumnName[i] = reader["COLUMN_NAME"].ToString();
                i++;
            }
            reader.Close();
        }

        public void Panel_Click(object sender, EventArgs e)
        {
            guna2CircleButton1.Show();
            guna2CircleButton2.Show();
            r = 0;
            flowLayoutPanel2.Controls.Clear();
            pressed++;
            if (pressed == 1)
            {
                graphDisplay.Series[0].Points.Clear();
                panels[lastClicked].Enabled = true;
                pressed = 0;
            }
            editGraph.Enabled = true;
            var text = (sender as Guna2Panel).Name;//Gets what was double clicked
            string GRAPHDataName = text.ToString();// THIS IS THE TABLE THAT THE USER SELECTED
            string[] DataName = GRAPHDataName.Split(',');
            currentllySeletedGraph = DataName[1];
            currentJ = int.Parse(DataName[0]);
            lastClicked = int.Parse(DataName[0]);
            panels[int.Parse(DataName[0])].Enabled = false;
            GraphNameLabel.Text = DataName[1];
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            GraphColumn(DataName[1]);

            if (GraphColumnName[2] == "Line")
            {
                graphDisplay.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                graphType.Text = "Line Graph";
            }
            else if (GraphColumnName[2] == "Bar")
            {
                graphDisplay.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                graphType.Text = "Bar Graph";
            }
            else if (GraphColumnName[2] == "Column")
            {
                graphDisplay.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                graphType.Text = "Column Graph";
            }
            else if (GraphColumnName[2] == "Pie")
            { 
                graphDisplay.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                graphType.Text = "Pie Graph";
            }

            string tablevalues = "SELECT [" + GraphColumnName[0] + "],[" + GraphColumnName[1] + "] FROM [" + DataName[1] + "];";
            SqlCommand command2 = new SqlCommand(tablevalues, connection);
            var reader2 = command2.ExecuteReader();

            graphDisplay.ChartAreas[0].AxisX.Title = GraphColumnName[0];
            graphDisplay.ChartAreas[0].AxisY.Title = GraphColumnName[1];
            while (reader2.Read())
            {
                string column1 = reader2[GraphColumnName[0]].ToString();
                string column2 = reader2[GraphColumnName[1]].ToString();
                graphDisplay.Series[0].Points.AddXY(column1, double.Parse(column2));
            }
            reader2.Close();

            string editvalues = "SELECT [" + GraphColumnName[0] + "],[" + GraphColumnName[1] + "] FROM \"" + DataName[1] + "\";";
            SqlCommand com2 = new SqlCommand(editvalues, connection);
            var reader3 = com2.ExecuteReader();

            label1.Text = GraphColumnName[0].ToString();
            label2.Text = GraphColumnName[1].ToString();
            while (reader3.Read())
            {
                flowLayoutPanels2[r] = new FlowLayoutPanel();//instanstiation of a new flowlayoutpanel
                flowLayoutPanels2[r].Size = new Size(240, 20);//size of the panel
                flowLayoutPanel2.Controls.Add(flowLayoutPanels2[r]);// adds it to the main panel

                textBoxes1[r] = new TextBox();//instansitation of textboxes1
                textBoxes2[r] = new TextBox();
                textBoxes1[r].TextAlign = HorizontalAlignment.Center;
                textBoxes2[r].TextAlign = HorizontalAlignment.Center;
                textBoxes1[r].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBoxes1[r].ForeColor = System.Drawing.Color.Black;
                textBoxes2[r].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBoxes2[r].ForeColor = System.Drawing.Color.Black;

                if ((r%2) == 0)
                {
                    textBoxes1[r].BackColor = Color.FromArgb(235, 221, 240);
                    textBoxes2[r].BackColor = Color.FromArgb(235, 221, 240);
                }
                else
                {
                    textBoxes1[r].BackColor = Color.FromArgb(225, 205, 233);
                    textBoxes2[r].BackColor = Color.FromArgb(225, 205, 233);
                }

                textBoxes1[r].BorderStyle = BorderStyle.None;
                textBoxes2[r].BorderStyle = BorderStyle.None;
                flowLayoutPanels2[r].Controls.Add(textBoxes1[r]);//adds
                flowLayoutPanels2[r].Controls.Add(textBoxes2[r]);

                textBoxes1[r].Text = reader3[GraphColumnName[0]].ToString();
                textBoxes2[r].Text = reader3[GraphColumnName[1]].ToString();


                buttons1[r] = new Button();
                buttons1[r].FlatStyle = FlatStyle.Popup;
                buttons1[r].ForeColor = System.Drawing.Color.White;
                buttons1[r].Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
                buttons1[r].Name = "button" + j.ToString();//buttona name
                buttons1[r].Size = new Size(20, 20);//button size
                buttons1[r].Text = "X";//button text
                buttons1[r].Click += button_Click;// button property when clicked(Delete funtion)
                flowLayoutPanels2[r].Controls.Add(buttons1[r]);//adds it to the panel

                r++;//increment of the amount of sets
            }
            reader3.Close();

            connection.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var remove = (sender as Button).Name;//gets the button name
            string removePanel = remove.Remove(0, 6);//removes the "button" and just gets the number of the button
            flowLayoutPanel2.Controls.Remove(flowLayoutPanels2[int.Parse(removePanel)]);
            r--;
        }

        private void graphsCount_Click(object sender, EventArgs e)
        {

        }

        public void Delete_Button(object sender, EventArgs e)
        {
            var remove = (sender as Guna2CircleButton).Name;//gets the button name
            string Data = remove.ToString();
            string[] DataName = Data.Split(',');
            flowLayoutPanel1.Controls.Remove(GradientPanels[int.Parse(DataName[0])]);
            graphCount--;
            Graph_Count();
            j--;

            string GraphTableName = DataName[1];
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            GraphColumn(GraphTableName);

            string dropTable = "DROP TABLE [" + GraphTableName + "]";
            var command2 = new SqlCommand(dropTable, connection);
            command2.ExecuteNonQuery();

            connection.Close();
        }

        private void editGraph_Click(object sender, EventArgs e)
        {
            editNameGraph++;
            if (editNameGraph == 1)
            { 
            GraphNameLabel.Hide();
            textBox1.Text = GraphNameLabel.Text;
            textBox1.Show();
            textBox1.Focus();
            }
            if (editNameGraph == 2)
            {
            GraphNameLabel.Text = textBox1.Text;
            textBox1.Hide();
            editNameGraph = 0;
            GraphNameLabel.Show();
            //////////////////////////////////////CONNECTION PART/////////////////////////////////////////////////////////
            string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";//online database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            ///////////////////////////////////////ADDS table names in the databse in a list////////////////////////////
            string tableName = "SELECT * FROM information_schema.tables;";
            var cmdTable = new SqlCommand(tableName, connection);// to check if the name is in the database part
            SqlDataReader reader = cmdTable.ExecuteReader();//reads the schema of the table
            List<string> tableData = new List<string>();//for the tables

            while (reader.Read())//adds all the tables in the list above^^^
            {
                tableData.Add(reader["TABLE_NAME"].ToString());
            }
            reader.Close();//closes reader

            ////////////////////////////////////////////CONDITIONAL PART////////////////////////////////////////////////////
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Table name can't be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlParameter param2 = new SqlParameter("@currentTableName", currentllySeletedGraph);//parameter for the desired change
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add(param1);
                command.Parameters.Add(param2);
                command.ExecuteNonQuery();
                labels[currentJ].Text = textBox1.Text;
                panels[currentJ].Name = currentJ+","+textBox1.Text;
                //MessageBox.Show("Table name edited", "edited name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GraphNameLabel_DoubleClick(object sender, EventArgs e)
        {
            editNameGraph++;
            if (editNameGraph == 1)
            {
                GraphNameLabel.Hide();
                textBox1.Text = GraphNameLabel.Text;
                textBox1.Show();
                textBox1.Focus();
            }
            if (editNameGraph == 2)
            {
                GraphNameLabel.Text = textBox1.Text;
                textBox1.Hide();
                editNameGraph = 0;
                GraphNameLabel.Show();
                //////////////////////////////////////CONNECTION PART/////////////////////////////////////////////////////////
                string connectionString = "Data Source=sql5053.site4now.net;Initial Catalog=DB_A6B6E6_Data;User Id=DB_A6B6E6_Data_admin;Password=abc123456;";//online database
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                ///////////////////////////////////////ADDS table names in the databse in a list////////////////////////////
                string tableName = "SELECT * FROM information_schema.tables;";
                var cmdTable = new SqlCommand(tableName, connection);// to check if the name is in the database part
                SqlDataReader reader = cmdTable.ExecuteReader();//reads the schema of the table
                List<string> tableData = new List<string>();//for the tables

                while (reader.Read())//adds all the tables in the list above^^^
                {
                    tableData.Add(reader["TABLE_NAME"].ToString());
                }
                reader.Close();//closes reader

                ////////////////////////////////////////////CONDITIONAL PART////////////////////////////////////////////////////
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Table name can't be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    SqlParameter param2 = new SqlParameter("@currentTableName", currentllySeletedGraph);//parameter for the desired change
                    var command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);
                    command.ExecuteNonQuery();
                    labels[currentJ].Text = textBox1.Text;
                    panels[currentJ].Name = currentJ + "," + textBox1.Text;
                    //MessageBox.Show("Table name edited", "edited name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string GraphTableName = currentllySeletedGraph;
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

            string dropTable = "DELETE FROM [" + GraphTableName + "] WHERE " + GraphColumnName[2] + " IS NULL;";
            var command2 = new SqlCommand(dropTable, connection);
            command2.ExecuteNonQuery();

            bool finish = false;
            for (int n = 0; n < r; n++)
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

                string GRAPHDataName = currentllySeletedGraph;// THIS IS THE TABLE THAT THE USER SELECTED
                graphDisplay.Series[0].Points.Clear();
                string tablevalues = "SELECT [" + GraphColumnName[0] + "],[" + GraphColumnName[1] + "] FROM \"" + GRAPHDataName + "\";";
                SqlCommand command3 = new SqlCommand(tablevalues, connection);
                var reader2 = command3.ExecuteReader();

                graphDisplay.ChartAreas[0].AxisX.Title = GraphColumnName[0];
                graphDisplay.ChartAreas[0].AxisY.Title = GraphColumnName[1];

                while (reader2.Read())
                {
                    string column1 = reader2[GraphColumnName[0]].ToString();
                    string column2 = reader2[GraphColumnName[1]].ToString();
                    graphDisplay.Series[0].Points.AddXY(column1, double.Parse(column2));
                }
                reader2.Close();
                r = 0;
            }

            connection.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (r == amount)
            {
                MessageBox.Show("Maximum of 100 values can be added at a time");
                return;
            }
            else
            {
                flowLayoutPanels2[r] = new FlowLayoutPanel();//instanstiation of a new flowlayoutpanel
                flowLayoutPanels2[r].Size = new Size(240, 20);//size of the panel
                flowLayoutPanel2.Controls.Add(flowLayoutPanels2[r]);// adds it to the main panel

                textBoxes1[r] = new TextBox();//instansitation of textboxes1
                textBoxes2[r] = new TextBox();
                textBoxes1[r].TextAlign = HorizontalAlignment.Center;
                textBoxes2[r].TextAlign = HorizontalAlignment.Center;
                textBoxes1[r].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBoxes1[r].ForeColor = System.Drawing.Color.Black;
                textBoxes2[r].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBoxes2[r].ForeColor = System.Drawing.Color.Black;

                if ((r % 2) == 0)
                {
                    textBoxes1[r].BackColor = Color.FromArgb(235, 221, 240);
                    textBoxes2[r].BackColor = Color.FromArgb(235, 221, 240);
                }
                else
                {
                    textBoxes1[r].BackColor = Color.FromArgb(225, 205, 233);
                    textBoxes2[r].BackColor = Color.FromArgb(225, 205, 233);
                }

                textBoxes1[r].BorderStyle = BorderStyle.None;
                textBoxes2[r].BorderStyle = BorderStyle.None;
                flowLayoutPanels2[r].Controls.Add(textBoxes1[r]);//adds
                flowLayoutPanels2[r].Controls.Add(textBoxes2[r]);

                buttons1[r] = new Button();
                buttons1[r].FlatStyle = FlatStyle.Popup;
                buttons1[r].ForeColor = System.Drawing.Color.White;
                buttons1[r].Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
                buttons1[r].Name = "button" + j.ToString();//buttona name
                buttons1[r].Size = new Size(20, 20);//button size
                buttons1[r].Text = "X";//button text
                buttons1[r].Click += button_Click;// button property when clicked(Delete funtion)
                flowLayoutPanels2[r].Controls.Add(buttons1[r]);//adds it to the panel
                r++;
            }
        }

        private void graphDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
