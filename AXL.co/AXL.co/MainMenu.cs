using System;
using LiveCharts.WinForms;
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

namespace AXL.co
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        int buttonclicko = 1;
        LiveCharts.WinForms.GeoMap geomap = new LiveCharts.WinForms.GeoMap();


        public static int test(HtmlNode[] node, int country, int item)
        {
            int total = 0;

            string s = node[country].InnerText.ToString();
            string[] sa = s.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            try
            {
                total = int.Parse(sa[item].Replace(",", ""));
            }
            catch { total = 0; }
            return total;
        }
        public static string TotalString(HtmlNode[] node, int country, int item)
        {
            string total;
            string s = node[country].InnerText.ToString();
            string[] sa = s.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            try
            {
                total = sa[item];
            }
            catch { total = "0"; }
            return total;
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //"Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=YOUR_DB_PASSWORD
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=labyumarc123";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open


            string insertInto = "INSERT INTO todo (todolist) VALUES (@Xvalues)";
            SqlParameter param1 = new SqlParameter("@Xvalues", todoEntry.Text);
            SqlCommand cmd = new SqlCommand(insertInto, connection);
            cmd.Parameters.Add(param1);
            cmd.ExecuteNonQuery();
            if (todoEntry.Text != string.Empty)
            {
                ListViewItem lvi = new ListViewItem();
                todoList.Items.Add(todoEntry.Text);
                todoEntry.Text = string.Empty;
            }
            connection.Close();//closses connection
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            panel1.Show();

            //map1
            LiveCharts.WinForms.GeoMap geomap = new LiveCharts.WinForms.GeoMap();
            //reads website
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.worldometers.info/coronavirus/");
            HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//tbody//tr").ToArray();
            geomap.Hoverable = true;
            int x = 8;//Starting:US
            int totals = 3;//Total Items
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict["US"] = test(nodes, x, totals); x += 1;
            dict["IN"] = test(nodes, x, totals); x += 1;
            dict["BR"] = test(nodes, x, totals); x += 1;
            dict["RU"] = test(nodes, x, totals); x += 1;
            dict["FR"] = test(nodes, x, totals); x += 1;
            dict["IT"] = test(nodes, x, totals); x += 1;
            dict["GB"] = test(nodes, x, totals); x += 1;
            dict["ES"] = test(nodes, x, totals); x += 1;
            dict["AR"] = test(nodes, x, totals); x += 1;
            dict["CO"] = test(nodes, x, totals); x += 1;
            dict["DE"] = test(nodes, x, totals); x += 1;
            dict["MX"] = test(nodes, x, totals); x += 1;
            dict["PL"] = test(nodes, x, totals); x += 1;
            dict["IR"] = test(nodes, x, totals); x += 1;
            dict["PE"] = test(nodes, x, totals); x += 1;
            dict["TR"] = test(nodes, x, totals); x += 1;
            dict["UA"] = test(nodes, x, totals); x += 1;
            dict["ZA"] = test(nodes, x, totals); x += 1;
            dict["BE"] = test(nodes, x, totals); x += 1;
            dict["ID"] = test(nodes, x, totals); x += 1;
            dict["NL"] = test(nodes, x, totals); x += 1;
            dict["IQ"] = test(nodes, x, totals); x += 1;
            dict["CL"] = test(nodes, x, totals); x += 1;
            dict["CZ"] = test(nodes, x, totals); x += 1;
            dict["RO"] = test(nodes, x, totals); x += 1;
            dict["BD"] = test(nodes, x, totals); x += 1;
            dict["PH"] = test(nodes, x, totals); x += 1;
            dict["CA"] = test(nodes, x, totals); x += 1;
            dict["PK"] = test(nodes, x, totals); x += 1;
            dict["MA"] = test(nodes, x, totals); x += 1;
            dict["SA"] = test(nodes, x, totals); x += 1;
            dict["CH"] = test(nodes, x, totals); x += 1;
            dict["IL"] = test(nodes, x, totals); x += 1;
            dict["PT"] = test(nodes, x, totals); x += 1;
            dict["AT"] = test(nodes, x, totals); x += 1;
            dict["SE"] = test(nodes, x, totals); x += 1;
            dict["HU"] = test(nodes, x, totals); x += 1;
            dict["JO"] = test(nodes, x, totals); x += 1;
            dict["NP"] = test(nodes, x, totals); x += 1;
            dict["YF"] = test(nodes, x, totals); x += 1;
            dict["EC"] = test(nodes, x, totals); x += 1;
            dict["PA"] = test(nodes, x, totals); x += 1;
            dict["AE"] = test(nodes, x, totals); x += 1;
            dict["GE"] = test(nodes, x, totals); x += 1;
            dict["BG"] = test(nodes, x, totals); x += 1;
            dict["JP"] = test(nodes, x, totals); x += 1;
            dict["HR"] = test(nodes, x, totals); x += 1;
            dict["AZ"] = test(nodes, x, totals); x += 1;
            dict["BY"] = test(nodes, x, totals); x += 1;
            dict["DO"] = test(nodes, x, totals); x += 1;
            dict["CR"] = test(nodes, x, totals); x += 1;
            dict["BO"] = test(nodes, x, totals); x += 1;
            dict["KW"] = test(nodes, x, totals); x += 1;
            dict["AM"] = test(nodes, x, totals); x += 1;
            dict["QA"] = test(nodes, x, totals); x += 1;
            dict["LB"] = test(nodes, x, totals); x += 1;
            dict["KZ"] = test(nodes, x, totals); x += 1;
            dict["GT"] = test(nodes, x, totals); x += 1;
            dict["OM"] = test(nodes, x, totals); x += 1;
            dict["EG"] = test(nodes, x, totals); x += 1;
            dict["SK"] = test(nodes, x, totals); x += 1;
            dict["MD"] = test(nodes, x, totals); x += 1;
            dict["GR"] = test(nodes, x, totals); x += 1;
            dict["ET"] = test(nodes, x, totals); x += 1;
            dict["HN"] = test(nodes, x, totals); x += 1;
            dict["TN"] = test(nodes, x, totals); x += 1;
            dict["VE"] = test(nodes, x, totals); x += 1;
            dict["MM"] = test(nodes, x, totals); x += 1;
            dict["GZ"] = test(nodes, x, totals); x += 1;
            dict["BA"] = test(nodes, x, totals); x += 1;
            dict["DK"] = test(nodes, x, totals); x += 1;
            dict["PY"] = test(nodes, x, totals); x += 1;
            dict["DZ"] = test(nodes, x, totals); x += 1;
            dict["KE"] = test(nodes, x, totals); x += 2;// -
            dict["LY"] = test(nodes, x, totals); x += 1;
            dict["SI"] = test(nodes, x, totals);
            dict["CN"] = test(nodes, x, totals); x += 1;
            dict["LT"] = test(nodes, x, totals); x += 1;
            dict["KG"] = test(nodes, x, totals); x += 1;
            dict["MY"] = test(nodes, x, totals); x += 1;
            dict["IE"] = test(nodes, x, totals); x += 1;
            dict["UZ"] = test(nodes, x, totals); x += 1;
            dict["NG"] = test(nodes, x, totals); x += 1;
            dict["MK"] = test(nodes, x, totals); x += 2;//-
            dict["GH"] = test(nodes, x, totals); x += 1;
            dict["AF"] = test(nodes, x, totals); x += 1;
            dict["AL"] = test(nodes, x, totals); x += 1;
            dict["SV"] = test(nodes, x, totals); x += 1;
            dict["KR"] = test(nodes, x, totals); x += 1;
            dict["NO"] = test(nodes, x, totals); x += 1;
            dict["ME"] = test(nodes, x, totals); x += 1;
            dict["LU"] = test(nodes, x, totals); x += 1;
            dict["LK"] = test(nodes, x, totals); x += 1;
            dict["FI"] = test(nodes, x, totals); x += 1;
            dict["AU"] = test(nodes, x, totals); x += 1;
            dict["CM"] = test(nodes, x, totals); x += 1;
            dict["UG"] = test(nodes, x, totals); x += 1;
            dict["LV"] = test(nodes, x, totals); x += 1;
            dict["CI"] = test(nodes, x, totals); x += 1;
            dict["SD"] = test(nodes, x, totals); x += 1;
            dict["ZM"] = test(nodes, x, totals); x += 1;
            dict["MG"] = test(nodes, x, totals); x += 1;
            dict["SN"] = test(nodes, x, totals); x += 1;
            dict["MZ"] = test(nodes, x, totals); x += 1;
            dict["AO"] = test(nodes, x, totals); x += 1;
            dict["EE"] = test(nodes, x, totals); x += 2; //-
            dict["NA"] = test(nodes, x, totals); x += 1;
            dict["ZR"] = test(nodes, x, totals); x += 1;
            dict["CY"] = test(nodes, x, totals); x += 1;
            dict["GN"] = test(nodes, x, totals); x += 2;//-
            dict["TJ"] = test(nodes, x, totals); x += 1;
            dict["BW"] = test(nodes, x, totals); x += 2;//-
            dict["JM"] = test(nodes, x, totals); x += 2;//-
            dict["ZW"] = test(nodes, x, totals); x += 2;//-
            dict["MR"] = test(nodes, x, totals); x += 1;
            dict["HT"] = test(nodes, x, totals); x += 1;
            dict["GA"] = test(nodes, x, totals); x += 1;
            dict["CU"] = test(nodes, x, totals); x += 1;
            dict["SY"] = test(nodes, x, totals); x += 3;//-
            dict["BZ"] = test(nodes, x, totals); x += 1;
            dict["UY"] = test(nodes, x, totals); x += 1;
            dict["BS"] = test(nodes, x, totals); x += 3;//-
            dict["TT"] = test(nodes, x, totals); x += 2;//-
            dict["SZ"] = test(nodes, x, totals); x += 1;
            dict["RW"] = test(nodes, x, totals); x += 1;
            dict["MW"] = test(nodes, x, totals); x += 1;
            dict["NI"] = test(nodes, x, totals); x += 1;
            dict["CG"] = test(nodes, x, totals); x += 1;
            dict["DJ"] = test(nodes, x, totals); x += 1;
            dict["GY"] = test(nodes, x, totals); x += 2;//-
            dict["IS"] = test(nodes, x, totals); x += 1;
            dict["ML"] = test(nodes, x, totals); x += 1;
            dict["SR"] = test(nodes, x, totals); x += 2;//-
            dict["GQ"] = test(nodes, x, totals); x += 2;//-
            dict["CF"] = test(nodes, x, totals); x += 1;
            dict["-994"] = test(nodes, x, totals); x += 1;
            dict["SO"] = test(nodes, x, totals); x += 1;
            dict["TH"] = test(nodes, x, totals); x += 1;
            dict["GM"] = test(nodes, x, totals); x += 1;
            dict["BF"] = test(nodes, x, totals); x += 1;
            dict["SS"] = test(nodes, x, totals); x += 1;
            dict["TG"] = test(nodes, x, totals); x += 1;
            dict["BJ"] = test(nodes, x, totals); x += 1;
            dict["GW"] = test(nodes, x, totals); x += 1;
            dict["SL"] = test(nodes, x, totals); x += 1;
            dict["LS"] = test(nodes, x, totals); x += 1;
            dict["NZ"] = test(nodes, x, totals); x += 1;
            dict["RY"] = test(nodes, x, totals); x += 1;
            dict["NE"] = test(nodes, x, totals); x += 3;//-
            dict["TD"] = test(nodes, x, totals); x += 1;
            dict["LR"] = test(nodes, x, totals); x += 2;//-
            dict["VN"] = test(nodes, x, totals); x += 4;//-
            dict["MN"] = test(nodes, x, totals); x += 3;//-
            dict["-995"] = test(nodes, x, totals); x += 1;
            dict["BI"] = test(nodes, x, totals); x += 2;//-
            dict["PG"] = test(nodes, x, totals); x += 1;
            dict["ER"] = test(nodes, x, totals); x += 4; //-
            dict["TZ"] = test(nodes, x, totals); x += 1;
            dict["BT"] = test(nodes, x, totals); x += 2; //-
            dict["KH"] = test(nodes, x, totals); x += 6;//-
            dict["NL"] = test(nodes, x, totals); x += 2;//-
            dict["BN"] = test(nodes, x, totals); x += 3;//-
            dict["DO"] = test(nodes, x, totals); x += 3;//-
            dict["FJ"] = test(nodes, x, totals); x += 2;//-
            dict["LA"] = test(nodes, x, totals); x += 1;
            dict["NC"] = test(nodes, x, totals); x += 1;
            dict["TP"] = test(nodes, x, totals); x += 3; //-
            dict["GL"] = test(nodes, x, totals); x += 1;
            dict["-992"] = test(nodes, x, totals); x += 1;
            dict["SB"] = test(nodes, x, totals); x += 3;//-
            dict["-993"] = test(nodes, x, totals); x += 5;//-
            dict["VU"] = test(nodes, x, totals); x += 1;
            dict["KP"] = 0;
            dict["TM"] = 0;
            dict["KV"] = 0;


            geomap.HeatMap = dict;
            geomap.EnableZoomingAndPanning = true;
            geomap.Source = $"{Application.StartupPath}\\World.xml";
            panel1.Controls.Add(geomap);
            geomap.Dock = DockStyle.Fill;


            /// map2
            int deaths = 5;
            int y = 8;
            LiveCharts.WinForms.GeoMap geomap2 = new LiveCharts.WinForms.GeoMap();
            geomap2.Hoverable = true;
            Dictionary<string, double> dict2 = new Dictionary<string, double>();
            dict2["US"] = test(nodes, y, deaths); y += 1;
            dict2["IN"] = test(nodes, y, deaths); y += 1;
            dict2["BR"] = test(nodes, y, deaths); y += 1;
            dict2["RU"] = test(nodes, y, deaths); y += 1;
            dict2["FR"] = test(nodes, y, deaths); y += 1;
            dict2["IT"] = test(nodes, y, deaths); y += 1;
            dict2["GB"] = test(nodes, y, deaths); y += 1;
            dict2["ES"] = test(nodes, y, deaths); y += 1;
            dict2["AR"] = test(nodes, y, deaths); y += 1;
            dict2["CO"] = test(nodes, y, deaths); y += 1;
            dict2["DE"] = test(nodes, y, deaths); y += 1;
            dict2["MX"] = test(nodes, y, deaths); y += 1;
            dict2["PL"] = test(nodes, y, deaths); y += 1;
            dict2["IR"] = test(nodes, y, deaths); y += 1;
            dict2["PE"] = test(nodes, y, deaths); y += 1;
            dict2["TR"] = test(nodes, y, deaths); y += 1;
            dict2["UA"] = test(nodes, y, deaths); y += 1;
            dict2["ZA"] = test(nodes, y, deaths); y += 1;
            dict2["BE"] = test(nodes, y, deaths); y += 1;
            dict2["ID"] = test(nodes, y, deaths); y += 1;
            dict2["NL"] = test(nodes, y, deaths); y += 1;
            dict2["IQ"] = test(nodes, y, deaths); y += 1;
            dict2["CL"] = test(nodes, y, deaths); y += 1;
            dict2["CZ"] = test(nodes, y, deaths); y += 1;
            dict2["RO"] = test(nodes, y, deaths); y += 1;
            dict2["BD"] = test(nodes, y, deaths); y += 1;
            dict2["PH"] = test(nodes, y, deaths); y += 1;
            dict2["CA"] = test(nodes, y, deaths); y += 1;
            dict2["PK"] = test(nodes, y, deaths); y += 1;
            dict2["MA"] = test(nodes, y, deaths); y += 1;
            dict2["SA"] = test(nodes, y, deaths); y += 1;
            dict2["CH"] = test(nodes, y, deaths); y += 1;
            dict2["IL"] = test(nodes, y, deaths); y += 1;
            dict2["PT"] = test(nodes, y, deaths); y += 1;
            dict2["AT"] = test(nodes, y, deaths); y += 1;
            dict2["SE"] = test(nodes, y, deaths); y += 1;
            dict2["HU"] = test(nodes, y, deaths); y += 1;
            dict2["JO"] = test(nodes, y, deaths); y += 1;
            dict2["NP"] = test(nodes, y, deaths); y += 1;
            dict2["YF"] = test(nodes, y, deaths); y += 1;
            dict2["EC"] = test(nodes, y, deaths); y += 1;
            dict2["PA"] = test(nodes, y, deaths); y += 1;
            dict2["AE"] = test(nodes, y, deaths); y += 1;
            dict2["GE"] = test(nodes, y, deaths); y += 1;
            dict2["BG"] = test(nodes, y, deaths); y += 1;
            dict2["JP"] = test(nodes, y, deaths); y += 1;
            dict2["HR"] = test(nodes, y, deaths); y += 1;
            dict2["AZ"] = test(nodes, y, deaths); y += 1;
            dict2["BY"] = test(nodes, y, deaths); y += 1;
            dict2["DO"] = test(nodes, y, deaths); y += 1;
            dict2["CR"] = test(nodes, y, deaths); y += 1;
            dict2["BO"] = test(nodes, y, deaths); y += 1;
            dict2["KW"] = test(nodes, y, deaths); y += 1;
            dict2["AM"] = test(nodes, y, deaths); y += 1;
            dict2["QA"] = test(nodes, y, deaths); y += 1;
            dict2["LB"] = test(nodes, y, deaths); y += 1;
            dict2["KZ"] = test(nodes, y, deaths); y += 1;
            dict2["GT"] = test(nodes, y, deaths); y += 1;
            dict2["OM"] = test(nodes, y, deaths); y += 1;
            dict2["EG"] = test(nodes, y, deaths); y += 1;
            dict2["SK"] = test(nodes, y, deaths); y += 1;
            dict2["MD"] = test(nodes, y, deaths); y += 1;
            dict2["GR"] = test(nodes, y, deaths); y += 1;
            dict2["ET"] = test(nodes, y, deaths); y += 1;
            dict2["HN"] = test(nodes, y, deaths); y += 1;
            dict2["TN"] = test(nodes, y, deaths); y += 1;
            dict2["VE"] = test(nodes, y, deaths); y += 1;
            dict2["MM"] = test(nodes, y, deaths); y += 1;
            dict2["GZ"] = test(nodes, y, deaths); y += 1;
            dict2["BA"] = test(nodes, y, deaths); y += 1;
            dict2["DK"] = test(nodes, y, deaths); y += 1;
            dict2["PY"] = test(nodes, y, deaths); y += 1;
            dict2["DZ"] = test(nodes, y, deaths); y += 1;
            dict2["KE"] = test(nodes, y, deaths); y += 2;// -
            dict2["LY"] = test(nodes, y, deaths); y += 1;
            dict2["SI"] = test(nodes, y, deaths);
            dict2["CN"] = test(nodes, y, deaths); y += 1;
            dict2["LT"] = test(nodes, y, deaths); y += 1;
            dict2["KG"] = test(nodes, y, deaths); y += 1;
            dict2["MY"] = test(nodes, y, deaths); y += 1;
            dict2["IE"] = test(nodes, y, deaths); y += 1;
            dict2["UZ"] = test(nodes, y, deaths); y += 1;
            dict2["NG"] = test(nodes, y, deaths); y += 1;
            dict2["MK"] = test(nodes, y, deaths); y += 2;//-
            dict2["GH"] = test(nodes, y, deaths); y += 1;
            dict2["AF"] = test(nodes, y, deaths); y += 1;
            dict2["AL"] = test(nodes, y, deaths); y += 1;
            dict2["SV"] = test(nodes, y, deaths); y += 1;
            dict2["KR"] = test(nodes, y, deaths); y += 1;
            dict2["NO"] = test(nodes, y, deaths); y += 1;
            dict2["ME"] = test(nodes, y, deaths); y += 1;
            dict2["LU"] = test(nodes, y, deaths); y += 1;
            dict2["LK"] = test(nodes, y, deaths); y += 1;
            dict2["FI"] = test(nodes, y, deaths); y += 1;
            dict2["AU"] = test(nodes, y, deaths); y += 1;
            dict2["CM"] = test(nodes, y, deaths); y += 1;
            dict2["UG"] = test(nodes, y, deaths); y += 1;
            dict2["LV"] = test(nodes, y, deaths); y += 1;
            dict2["CI"] = test(nodes, y, deaths); y += 1;
            dict2["SD"] = test(nodes, y, deaths); y += 1;
            dict2["ZM"] = test(nodes, y, deaths); y += 1;
            dict2["MG"] = test(nodes, y, deaths); y += 1;
            dict2["SN"] = test(nodes, y, deaths); y += 1;
            dict2["MZ"] = test(nodes, y, deaths); y += 1;
            dict2["AO"] = test(nodes, y, deaths); y += 1;
            dict2["EE"] = test(nodes, y, deaths); y += 2; //-
            dict2["NA"] = test(nodes, y, deaths); y += 1;
            dict2["ZR"] = test(nodes, y, deaths); y += 1;
            dict2["CY"] = test(nodes, y, deaths); y += 1;
            dict2["GN"] = test(nodes, y, deaths); y += 2;//-
            dict2["TJ"] = test(nodes, y, deaths); y += 1;
            dict2["BW"] = test(nodes, y, deaths); y += 2;//-
            dict2["JM"] = test(nodes, y, deaths); y += 2;//-
            dict2["ZW"] = test(nodes, y, deaths); y += 2;//-
            dict2["MR"] = test(nodes, y, deaths); y += 1;
            dict2["HT"] = test(nodes, y, deaths); y += 1;
            dict2["GA"] = test(nodes, y, deaths); y += 1;
            dict2["CU"] = test(nodes, y, deaths); y += 1;
            dict2["SY"] = test(nodes, y, deaths); y += 3;//-
            dict2["BZ"] = test(nodes, y, deaths); y += 1;
            dict2["UY"] = test(nodes, y, deaths); y += 1;
            dict2["BS"] = test(nodes, y, deaths); y += 3;//-
            dict2["TT"] = test(nodes, y, deaths); y += 2;//-
            dict2["SZ"] = test(nodes, y, deaths); y += 1;
            dict2["RW"] = test(nodes, y, deaths); y += 1;
            dict2["MW"] = test(nodes, y, deaths); y += 1;
            dict2["NI"] = test(nodes, y, deaths); y += 1;
            dict2["CG"] = test(nodes, y, deaths); y += 1;
            dict2["DJ"] = test(nodes, y, deaths); y += 1;
            dict2["GY"] = test(nodes, y, deaths); y += 2;//-
            dict2["IS"] = test(nodes, y, deaths); y += 1;
            dict2["ML"] = test(nodes, y, deaths); y += 1;
            dict2["SR"] = test(nodes, y, deaths); y += 2;//-
            dict2["GQ"] = test(nodes, y, deaths); y += 2;//-
            dict2["CF"] = test(nodes, y, deaths); y += 1;
            dict2["-994"] = test(nodes, y, deaths); y += 1;
            dict2["SO"] = test(nodes, y, deaths); y += 1;
            dict2["TH"] = test(nodes, y, deaths); y += 1;
            dict2["GM"] = test(nodes, y, deaths); y += 1;
            dict2["BF"] = test(nodes, y, deaths); y += 1;
            dict2["SS"] = test(nodes, y, deaths); y += 1;
            dict2["TG"] = test(nodes, y, deaths); y += 1;
            dict2["BJ"] = test(nodes, y, deaths); y += 1;
            dict2["GW"] = test(nodes, y, deaths); y += 1;
            dict2["SL"] = test(nodes, y, deaths); y += 1;
            dict2["LS"] = test(nodes, y, deaths); y += 1;
            dict2["NZ"] = test(nodes, y, deaths); y += 1;
            dict2["RY"] = test(nodes, y, deaths); y += 1;
            dict2["NE"] = test(nodes, y, deaths); y += 3;//-
            dict2["TD"] = test(nodes, y, deaths); y += 1;
            dict2["LR"] = test(nodes, y, deaths); y += 2;//-
            dict2["VN"] = test(nodes, y, deaths); y += 4;//-
            dict2["MN"] = test(nodes, y, deaths); y += 3;//-
            dict2["-995"] = test(nodes, y, deaths); y += 1;
            dict2["BI"] = test(nodes, y, deaths); y += 2;//-
            dict2["PG"] = test(nodes, y, deaths); y += 1;
            dict2["ER"] = test(nodes, y, deaths); y += 4; //-
            dict2["TZ"] = test(nodes, y, deaths); y += 1;
            dict2["BT"] = test(nodes, y, deaths); y += 2; //-
            dict2["KH"] = test(nodes, y, deaths); y += 6;//-
            dict2["NL"] = test(nodes, y, deaths); y += 2;//-
            dict2["BN"] = test(nodes, y, deaths); y += 3;//-
            dict2["DO"] = test(nodes, y, deaths); y += 3;//-
            dict2["FJ"] = test(nodes, y, deaths); y += 2;//-
            dict2["LA"] = test(nodes, y, deaths); y += 1;
            dict2["NC"] = test(nodes, y, deaths); y += 1;
            dict2["TP"] = test(nodes, y, deaths); y += 3; //-
            dict2["GL"] = test(nodes, y, deaths); y += 1;
            dict2["-992"] = test(nodes, y, deaths); y += 1;
            dict2["SB"] = test(nodes, y, deaths); y += 3;//-
            dict2["-993"] = test(nodes, y, deaths); y += 5;//-
            dict2["VU"] = test(nodes, y, deaths); y += 1;
            dict2["KP"] = 0;
            dict2["TM"] = 0;
            dict2["KV"] = 0;

            geomap2.HeatMap = dict2;
            geomap2.EnableZoomingAndPanning = true;
            geomap2.Source = $"{Application.StartupPath}\\World.xml";
            panel2.Controls.Add(geomap2);
            geomap2.Dock = DockStyle.Fill;


            // map3
            int recovered = 7;
            int z = 8;
            LiveCharts.WinForms.GeoMap geomap3 = new LiveCharts.WinForms.GeoMap();
            geomap3.Hoverable = true;
            Dictionary<string, double> dict3 = new Dictionary<string, double>();
            dict3["US"] = test(nodes, z, recovered); z += 1;
            dict3["IN"] = test(nodes, z, recovered); z += 1;
            dict3["BR"] = test(nodes, z, recovered); z += 1;
            dict3["RU"] = test(nodes, z, recovered); z += 1;
            dict3["FR"] = test(nodes, z, recovered); z += 1;
            dict3["IT"] = test(nodes, z, recovered); z += 1;
            dict3["GB"] = test(nodes, z, recovered); z += 1;
            dict3["ES"] = test(nodes, z, recovered); z += 1;
            dict3["AR"] = test(nodes, z, recovered); z += 1;
            dict3["CO"] = test(nodes, z, recovered); z += 1;
            dict3["DE"] = test(nodes, z, recovered); z += 1;
            dict3["MX"] = test(nodes, z, recovered); z += 1;
            dict3["PL"] = test(nodes, z, recovered); z += 1;
            dict3["IR"] = test(nodes, z, recovered); z += 1;
            dict3["PE"] = test(nodes, z, recovered); z += 1;
            dict3["TR"] = test(nodes, z, recovered); z += 1;
            dict3["UA"] = test(nodes, z, recovered); z += 1;
            dict3["ZA"] = test(nodes, z, recovered); z += 1;
            dict3["BE"] = test(nodes, z, recovered); z += 1;
            dict3["ID"] = test(nodes, z, recovered); z += 1;
            dict3["NL"] = test(nodes, z, recovered); z += 1;
            dict3["IQ"] = test(nodes, z, recovered); z += 1;
            dict3["CL"] = test(nodes, z, recovered); z += 1;
            dict3["CZ"] = test(nodes, z, recovered); z += 1;
            dict3["RO"] = test(nodes, z, recovered); z += 1;
            dict3["BD"] = test(nodes, z, recovered); z += 1;
            dict3["PH"] = test(nodes, z, recovered); z += 1;
            dict3["CA"] = test(nodes, z, recovered); z += 1;
            dict3["PK"] = test(nodes, z, recovered); z += 1;
            dict3["MA"] = test(nodes, z, recovered); z += 1;
            dict3["SA"] = test(nodes, z, recovered); z += 1;
            dict3["CH"] = test(nodes, z, recovered); z += 1;
            dict3["IL"] = test(nodes, z, recovered); z += 1;
            dict3["PT"] = test(nodes, z, recovered); z += 1;
            dict3["AT"] = test(nodes, z, recovered); z += 1;
            dict3["SE"] = test(nodes, z, recovered); z += 1;
            dict3["HU"] = test(nodes, z, recovered); z += 1;
            dict3["JO"] = test(nodes, z, recovered); z += 1;
            dict3["NP"] = test(nodes, z, recovered); z += 1;
            dict3["YF"] = test(nodes, z, recovered); z += 1;
            dict3["EC"] = test(nodes, z, recovered); z += 1;
            dict3["PA"] = test(nodes, z, recovered); z += 1;
            dict3["AE"] = test(nodes, z, recovered); z += 1;
            dict3["GE"] = test(nodes, z, recovered); z += 1;
            dict3["BG"] = test(nodes, z, recovered); z += 1;
            dict3["JP"] = test(nodes, z, recovered); z += 1;
            dict3["HR"] = test(nodes, z, recovered); z += 1;
            dict3["AZ"] = test(nodes, z, recovered); z += 1;
            dict3["BY"] = test(nodes, z, recovered); z += 1;
            dict3["DO"] = test(nodes, z, recovered); z += 1;
            dict3["CR"] = test(nodes, z, recovered); z += 1;
            dict3["BO"] = test(nodes, z, recovered); z += 1;
            dict3["KW"] = test(nodes, z, recovered); z += 1;
            dict3["AM"] = test(nodes, z, recovered); z += 1;
            dict3["QA"] = test(nodes, z, recovered); z += 1;
            dict3["LB"] = test(nodes, z, recovered); z += 1;
            dict3["KZ"] = test(nodes, z, recovered); z += 1;
            dict3["GT"] = test(nodes, z, recovered); z += 1;
            dict3["OM"] = test(nodes, z, recovered); z += 1;
            dict3["EG"] = test(nodes, z, recovered); z += 1;
            dict3["SK"] = test(nodes, z, recovered); z += 1;
            dict3["MD"] = test(nodes, z, recovered); z += 1;
            dict3["GR"] = test(nodes, z, recovered); z += 1;
            dict3["ET"] = test(nodes, z, recovered); z += 1;
            dict3["HN"] = test(nodes, z, recovered); z += 1;
            dict3["TN"] = test(nodes, z, recovered); z += 1;
            dict3["VE"] = test(nodes, z, recovered); z += 1;
            dict3["MM"] = test(nodes, z, recovered); z += 1;
            dict3["GZ"] = test(nodes, z, recovered); z += 1;
            dict3["BA"] = test(nodes, z, recovered); z += 1;
            dict3["DK"] = test(nodes, z, recovered); z += 1;
            dict3["PY"] = test(nodes, z, recovered); z += 1;
            dict3["DZ"] = test(nodes, z, recovered); z += 1;
            dict3["KE"] = test(nodes, z, recovered); z += 2;// -
            dict3["LY"] = test(nodes, z, recovered); z += 1;
            dict3["SI"] = test(nodes, z, recovered);
            dict3["CN"] = test(nodes, z, recovered); z += 1;
            dict3["LT"] = test(nodes, z, recovered); z += 1;
            dict3["KG"] = test(nodes, z, recovered); z += 1;
            dict3["MY"] = test(nodes, z, recovered); z += 1;
            dict3["IE"] = test(nodes, z, recovered); z += 1;
            dict3["UZ"] = test(nodes, z, recovered); z += 1;
            dict3["NG"] = test(nodes, z, recovered); z += 1;
            dict3["MK"] = test(nodes, z, recovered); z += 2;//-
            dict3["GH"] = test(nodes, z, recovered); z += 1;
            dict3["AF"] = test(nodes, z, recovered); z += 1;
            dict3["AL"] = test(nodes, z, recovered); z += 1;
            dict3["SV"] = test(nodes, z, recovered); z += 1;
            dict3["KR"] = test(nodes, z, recovered); z += 1;
            dict3["NO"] = test(nodes, z, recovered); z += 1;
            dict3["ME"] = test(nodes, z, recovered); z += 1;
            dict3["LU"] = test(nodes, z, recovered); z += 1;
            dict3["LK"] = test(nodes, z, recovered); z += 1;
            dict3["FI"] = test(nodes, z, recovered); z += 1;
            dict3["AU"] = test(nodes, z, recovered); z += 1;
            dict3["CM"] = test(nodes, z, recovered); z += 1;
            dict3["UG"] = test(nodes, z, recovered); z += 1;
            dict3["LV"] = test(nodes, z, recovered); z += 1;
            dict3["CI"] = test(nodes, z, recovered); z += 1;
            dict3["SD"] = test(nodes, z, recovered); z += 1;
            dict3["ZM"] = test(nodes, z, recovered); z += 1;
            dict3["MG"] = test(nodes, z, recovered); z += 1;
            dict3["SN"] = test(nodes, z, recovered); z += 1;
            dict3["MZ"] = test(nodes, z, recovered); z += 1;
            dict3["AO"] = test(nodes, z, recovered); z += 1;
            dict3["EE"] = test(nodes, z, recovered); z += 2; //-
            dict3["NA"] = test(nodes, z, recovered); z += 1;
            dict3["ZR"] = test(nodes, z, recovered); z += 1;
            dict3["CY"] = test(nodes, z, recovered); z += 1;
            dict3["GN"] = test(nodes, z, recovered); z += 2;//-
            dict3["TJ"] = test(nodes, z, recovered); z += 1;
            dict3["BW"] = test(nodes, z, recovered); z += 2;//-
            dict3["JM"] = test(nodes, z, recovered); z += 2;//-
            dict3["ZW"] = test(nodes, z, recovered); z += 2;//-
            dict3["MR"] = test(nodes, z, recovered); z += 1;
            dict3["HT"] = test(nodes, z, recovered); z += 1;
            dict3["GA"] = test(nodes, z, recovered); z += 1;
            dict3["CU"] = test(nodes, z, recovered); z += 1;
            dict3["SY"] = test(nodes, z, recovered); z += 3;//-
            dict3["BZ"] = test(nodes, z, recovered); z += 1;
            dict3["UY"] = test(nodes, z, recovered); z += 1;
            dict3["BS"] = test(nodes, z, recovered); z += 3;//-
            dict3["TT"] = test(nodes, z, recovered); z += 2;//-
            dict3["SZ"] = test(nodes, z, recovered); z += 1;
            dict3["RW"] = test(nodes, z, recovered); z += 1;
            dict3["MW"] = test(nodes, z, recovered); z += 1;
            dict3["NI"] = test(nodes, z, recovered); z += 1;
            dict3["CG"] = test(nodes, z, recovered); z += 1;
            dict3["DJ"] = test(nodes, z, recovered); z += 1;
            dict3["GY"] = test(nodes, z, recovered); z += 2;//-
            dict3["IS"] = test(nodes, z, recovered); z += 1;
            dict3["ML"] = test(nodes, z, recovered); z += 1;
            dict3["SR"] = test(nodes, z, recovered); z += 2;//-
            dict3["GQ"] = test(nodes, z, recovered); z += 2;//-
            dict3["CF"] = test(nodes, z, recovered); z += 1;
            dict3["-994"] = test(nodes, z, recovered); z += 1;
            dict3["SO"] = test(nodes, z, recovered); z += 1;
            dict3["TH"] = test(nodes, z, recovered); z += 1;
            dict3["GM"] = test(nodes, z, recovered); z += 1;
            dict3["BF"] = test(nodes, z, recovered); z += 1;
            dict3["SS"] = test(nodes, z, recovered); z += 1;
            dict3["TG"] = test(nodes, z, recovered); z += 1;
            dict3["BJ"] = test(nodes, z, recovered); z += 1;
            dict3["GW"] = test(nodes, z, recovered); z += 1;
            dict3["SL"] = test(nodes, z, recovered); z += 1;
            dict3["LS"] = test(nodes, z, recovered); z += 1;
            dict3["NZ"] = test(nodes, z, recovered); z += 1;
            dict3["RY"] = test(nodes, z, recovered); z += 1;
            dict3["NE"] = test(nodes, z, recovered); z += 3;//-
            dict3["TD"] = test(nodes, z, recovered); z += 1;
            dict3["LR"] = test(nodes, z, recovered); z += 2;//-
            dict3["VN"] = test(nodes, z, recovered); z += 4;//-
            dict3["MN"] = test(nodes, z, recovered); z += 3;//-
            dict3["-995"] = test(nodes, z, recovered); z += 1;
            dict3["BI"] = test(nodes, z, recovered); z += 2;//-
            dict3["PG"] = test(nodes, z, recovered); z += 1;
            dict3["ER"] = test(nodes, z, recovered); z += 4; //-
            dict3["TZ"] = test(nodes, z, recovered); z += 1;
            dict3["BT"] = test(nodes, z, recovered); z += 2; //-
            dict3["KH"] = test(nodes, z, recovered); z += 6;//-
            dict3["NL"] = test(nodes, z, recovered); z += 2;//-
            dict3["BN"] = test(nodes, z, recovered); z += 3;//-
            dict3["DO"] = test(nodes, z, recovered); z += 3;//-
            dict3["FJ"] = test(nodes, z, recovered); z += 2;//-
            dict3["LA"] = test(nodes, z, recovered); z += 1;
            dict3["NC"] = test(nodes, z, recovered); z += 1;
            dict3["TP"] = test(nodes, z, recovered); z += 3; //-
            dict3["GL"] = test(nodes, z, recovered); z += 1;
            dict3["-992"] = test(nodes, z, recovered); z += 1;
            dict3["SB"] = test(nodes, z, recovered); z += 3;//-
            dict3["-993"] = test(nodes, z, recovered); z += 5;//-
            dict3["VU"] = test(nodes, z, recovered); z += 1;
            dict3["KP"] = 0;
            dict3["TM"] = 0;
            dict3["KV"] = 0;
            geomap3.HeatMap = dict3;
            geomap3.EnableZoomingAndPanning = true;
            geomap3.Source = $"{Application.StartupPath}\\World.xml";
            panel3.Controls.Add(geomap3);
            geomap3.Dock = DockStyle.Fill;
            casesCount.Text = TotalString(nodes, 7, 3);
            deathsCount.Text = TotalString(nodes, 7, 5);
            recoveriesCount.Text = TotalString(nodes, 7, 7);
            date.Text = DateTime.Now.ToString("D");

            string tableName = "SELECT * FROM todo;";// sql commmand
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=labyumarc123";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            var cmdTable = new SqlCommand(tableName, connection);
            SqlDataReader reader = cmdTable.ExecuteReader();//reads the schema of the table

            while (reader.Read())//Puts the name of the tables in the database and adds a textbox in the flow panel
            {
                todoList.Items.Add(reader["todolist"]);

            }
            reader.Close();//closes reader
            connection.Close();//closses connection
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            buttonclicko ++;
            if (buttonclicko == 2)
            {
                button1.Enabled = true;
                panel2.Show();
                panel1.Hide();

            }
            if (buttonclicko == 3)
            {
                button2.Enabled = false;
                panel3.Show();
                panel2.Hide();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            buttonclicko --;
            if (buttonclicko == 1)
            {
                button1.Enabled = false;
                panel1.Show();
                panel2.Hide();
            }
            if (buttonclicko == 2)
            {
                button2.Enabled = true;
                panel2.Show();
                panel3.Hide();
            }
        }

        private void todoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void todoList_DoubleClick(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SQL5053.site4now.net;Initial Catalog=DB_A6BCC0_labyumarc123;User Id=DB_A6BCC0_labyumarc123_admin;Password=labyumarc123";
            SqlConnection connection = new SqlConnection(connectionString);//connectiong command sql
            connection.Open();//connectiong open

            string deleteItem = "DELETE FROM todo WHERE nothing IS NULL";
            SqlCommand cmd = new SqlCommand(deleteItem, connection);
            cmd.ExecuteNonQuery();

            foreach (object fruits in todoList.SelectedItems)
            {

                string ddeletedItem = fruits.ToString();
                string insertInto = "INSERT INTO todo (todolist) VALUES (@Xvalues)";
                SqlParameter param1 = new SqlParameter("@Xvalues", ddeletedItem);
                SqlCommand cmd2 = new SqlCommand(insertInto, connection);
                cmd2.Parameters.Add(param1);
                cmd2.ExecuteNonQuery();
            }
            connection.Close();
            todoList.Items.Remove(todoList.SelectedItem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("mm");
            int hours = int.Parse(DateTime.Now.ToString("HH"));
            if (hours >= 12)
            {
                hours -= 12;
                timee.Text = hours + " : " + time + "PM";
            }

            else timee.Text = hours + " : " + time + "AM";
        }
    }
}
