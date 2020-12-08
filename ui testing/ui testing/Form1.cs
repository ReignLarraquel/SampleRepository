using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Xml;
using HtmlAgilityPack;
using System.Data.SqlClient;
namespace ui_testing
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            string time = DateTime.Now.ToString("mm");
            int hours = int.Parse(DateTime.Now.ToString("HH"));
            if (hours >= 12)
            {
                hours -= 12;
                Clock.Text = hours + " : " + time + "PM";
            }

            else Clock.Text = hours + " : " + time + "AM";

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel1.Show();
            int total_values = 154;
            int x= 0;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.worldometers.info/coronavirus/");
            HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//tbody//tr//td").ToArray();
            LiveCharts.WinForms.GeoMap geomap = new LiveCharts.WinForms.GeoMap();
            geomap.Hoverable = true;
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict["US"] = int.Parse(nodes[total_values].InnerText.Replace(",", "")); x += 19;
            dict["IN"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["RU"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["FR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["ES"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["GB"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["IT"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["AR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CO"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["MX"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["DE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["PL"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["PE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["IR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["ZA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["UA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["TR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["IQ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CL"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["ID"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["NL"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["RO"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BD"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["PH"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["PK"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["MA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["IL"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CH"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["PT"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["AT"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["NP"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["HU"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["JO"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["EC"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["UA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["YF"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["AE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["PA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BO"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["DO"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["KW"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["JP"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BG"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["QA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BY"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["AM"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["GE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["KZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["HR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["LB"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["OM"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["GT"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["AZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["EG"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["ET"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["HN"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["MD"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SK"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["GR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["VE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["TN"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["MM"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38;//1
            dict["CN"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["GZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["KE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["LY"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["DZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["PY"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["DK"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SI"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["UZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["KG"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["IE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["NG"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["MY"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["MK"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["LT"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38;//1
            dict["GH"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["AF"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SV"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["AL"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["NO"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["ME"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["LU"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["KP"] = 0;
            dict["TM"] = 0;
            dict["KV"] = 0;
            dict["KR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["AU"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["FI"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CM"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["LK"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CI"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["UG"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["ZM"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SD"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["MG"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["LV"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SN"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["MZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["AO"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["NA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38;//1
            dict["GN"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38;//1
            dict["ZR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["TJ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["EE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 57; //2
            dict["JM"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BW"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CY"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["ZW"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38;//1
            dict["HT"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["GA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["MR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38;//1
            dict["CU"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38;//1
            dict["SY"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BS"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["TT"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 76;//3
            dict["MW"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["RW"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["NI"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CG"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["DJ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["UY"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38;//1
            dict["IS"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["GY"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38; //1
            dict["GQ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["CF"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38; //1
            dict["ML"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SO"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["TH"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["GM"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SS"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BJ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["TG"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["BF"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["GW"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SL"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38; //1
            dict["RY"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["LS"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["NZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["TD"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["LR"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38; //1
            dict["NE"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["VN"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 114;//5
            dict["MN"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 76; //3
            dict["BI"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["-995"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["PG"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 57; //2
            dict["ER"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["TZ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 57;//2
            dict["BT"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 38; //1
            dict["KH"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 114; //5
            dict["BN"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 152; //7
            dict["LA"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["FJ"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["NC"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["TP"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 57; //2
            dict["GL"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["SB"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 19;
            dict["-992"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 57; //2
            dict["-993"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", "")); x += 114; //5
            dict["VU"] = int.Parse(nodes[total_values+ x].InnerText.Replace(",", ""));
            geomap.HeatMap = dict;
            geomap.EnableZoomingAndPanning=true;
            geomap.Source = $"{Application.StartupPath}\\World.xml";
            panel1.Controls.Add(geomap);
            geomap.Dock = DockStyle.Fill;

            label2.Text = nodes[135].InnerText;
            label3.Text = nodes[136].InnerText;
            label4.Text = nodes[137].InnerText;
            label9.Text= nodes[138].InnerText;
            label11.Text = nodes[139].InnerText;

            string tableName = "SELECT * FROM todo;";// sql commmand
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=labyumarc123";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            var cmdTable = new SqlCommand(tableName, connection);
            SqlDataReader reader = cmdTable.ExecuteReader();//reads the schema of the table

            while (reader.Read())//Puts the name of the tables in the database and adds a textbox in the flow panel
            {
                listBox1.Items.Add(reader["todolist"]);

            }
            reader.Close();//closes reader
            connection.Close();//closses connection
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            //"Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=YOUR_DB_PASSWORD
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=labyumarc123";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

               
                    string insertInto = "INSERT INTO todo (todolist) VALUES (@Xvalues)";
                    SqlParameter param1 = new SqlParameter("@Xvalues", textBox1.Text);
                    SqlCommand cmd = new SqlCommand(insertInto, connection);
                    cmd.Parameters.Add(param1);                   
                    cmd.ExecuteNonQuery();
                    connection.Close();
            if (textBox1.Text != string.Empty)
            {
                ListViewItem lvi = new ListViewItem();
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=labyumarc123";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

                string deleteItem = "DELETE FROM todo WHERE nothing IS NULL";
                SqlCommand cmd = new SqlCommand(deleteItem, connection);
                cmd.ExecuteNonQuery();

            foreach(object fruits in listBox1.SelectedItems)
            {
                string ddeletedItem = fruits.ToString();
                string insertInto = "INSERT INTO todo (todolist) VALUES (@Xvalues)";
                SqlParameter param1 = new SqlParameter("@Xvalues", ddeletedItem);
                SqlCommand cmd2 = new SqlCommand(insertInto, connection);
                cmd2.Parameters.Add(param1);
                cmd2.ExecuteNonQuery();
            }

            for (int x = listBox1.SelectedIndices.Count-1 ; x >= 0; x--)
            {
                int idx = listBox1.SelectedIndices[x];
                listBox1.Items.RemoveAt(idx);
               
            }
            connection.Close();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
     
           
            

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_MouseHover(object sender, EventArgs e)
        {
           


        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("mm");
            int hours = int.Parse(DateTime.Now.ToString("HH"));
            if (hours >= 12)
            {
                hours -= 12;
                Clock.Text = hours + " : " + time + "PM";
            }

            else Clock.Text = hours + " : " + time + "AM";
        }

        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=labyumarc123";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            string deleteItem = "DELETE FROM todo WHERE nothing IS NULL";
            SqlCommand cmd = new SqlCommand(deleteItem, connection);
            cmd.ExecuteNonQuery();

            foreach (object fruits in listBox1.SelectedItems)
            {

                string ddeletedItem = fruits.ToString();
                string insertInto = "INSERT INTO todo (todolist) VALUES (@Xvalues)";
                SqlParameter param1 = new SqlParameter("@Xvalues", ddeletedItem);
                SqlCommand cmd2 = new SqlCommand(insertInto, connection);
                cmd2.Parameters.Add(param1);
                cmd2.ExecuteNonQuery();
            }
            connection.Close();
            listBox1.Items.Remove(listBox1.SelectedItem);

            //var text = (sender as ListBox).Text;//Gets what was double clicked
            //string a = text.ToString();
            //string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=labyumarc123";
            //SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            //connection.Open();//connectiong open

            //string deleteItem = "DELETE FROM todo WHERE todolist = "+ a+"";
            //SqlCommand cmd = new SqlCommand(deleteItem, connection);
            //cmd.ExecuteNonQuery();
            //listBox1.Items.Remove(listBox1.SelectedItem);

        }
    }

}

