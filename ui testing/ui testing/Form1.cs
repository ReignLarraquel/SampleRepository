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

namespace ui_testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            int x= 19;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.worldometers.info/coronavirus/");
            HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//tbody//tr//td").ToArray();
            int a = int.Parse(nodes[154 + x].InnerText.Replace(",", ""));
            //BIGBOISOLUTIONWIDTK smallpp = new BIGBOISOLUTIONWIDTK();
            LiveCharts.WinForms.GeoMap geomap = new LiveCharts.WinForms.GeoMap();
            geomap.Hoverable = true;
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict["US"] = int.Parse(nodes[154 ].InnerText.Replace(",", "")); x += 19;
            dict["IN"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["RU"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["FR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["ES"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["GB"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["IT"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["AR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CO"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["MX"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["DE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["PL"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["PE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["IR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["ZA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["UA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["TR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["IQ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CL"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["ID"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["NL"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["RO"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BD"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["PH"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["PK"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["MA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["IL"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CH"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["PT"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["AT"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["NP"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["HU"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["JO"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["EC"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["UA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["YF"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["AE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["PA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BO"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["DO"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["KW"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["JP"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BG"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["QA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BY"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["AM"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["GE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["KZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["HR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["LB"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["OM"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["GT"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["AZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["EG"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["ET"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["HN"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["MD"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SK"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["GR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["VE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["TN"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["MM"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38;//1
            dict["CN"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["GZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["KE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["LY"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["DZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["PY"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["DK"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SI"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["UZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["KG"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["IE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["NG"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["MY"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["MK"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["LT"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38;//1
            dict["GH"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["AF"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SV"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["AL"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["NO"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["ME"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["LU"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["KP"] = 0;
            dict["TM"] = 0;
            dict["KV"] = 0;
            dict["KR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["AU"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["FI"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CM"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["LK"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CI"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["UG"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["ZM"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SD"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["MG"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["LV"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SN"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["MZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["AO"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["NA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38;//1
            dict["GN"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38;//1
            dict["ZR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["TJ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["EE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 57; //2
            dict["JM"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BW"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CY"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["ZW"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38;//1
            dict["HT"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["GA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["MR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38;//1
            dict["CU"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38;//1
            dict["SY"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BS"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["TT"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 76;//3
            dict["MW"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["RW"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["NI"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CG"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["DJ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["UY"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38;//1
            dict["IS"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["GY"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38; //1
            dict["GQ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["CF"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38; //1
            dict["ML"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SO"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["TH"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["GM"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SS"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BJ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["TG"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["BF"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["GW"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SL"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38; //1
            dict["RY"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["LS"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["NZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["TD"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["LR"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38; //1
            dict["NE"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["VN"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 114;//5
            dict["MN"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 76; //3
            dict["BI"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["-995"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["PG"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 57; //2
            dict["ER"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["TZ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 57;//2
            dict["BT"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 38; //1
            dict["KH"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 114; //5
            dict["BN"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 152; //7
            dict["LA"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["FJ"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["NC"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["TP"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 57; //2
            dict["GL"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["SB"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 19;
            dict["-992"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 57; //2
            dict["-993"] = int.Parse(nodes[154 + x].InnerText.Replace(",", "")); x += 114; //5
            dict["VU"] = int.Parse(nodes[154 + x].InnerText.Replace(",", ""));

            geomap.HeatMap = dict;
            geomap.EnableZoomingAndPanning=true;
            geomap.Source = $"{Application.StartupPath}\\World.xml";
            panel1.Controls.Add(geomap);
            geomap.Dock = DockStyle.Fill;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }
    }

}

