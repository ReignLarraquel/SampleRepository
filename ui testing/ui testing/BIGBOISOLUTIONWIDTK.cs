//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net.Http;
//using System.Xml;
//using HtmlAgilityPack;

//namespace ui_testing
//{
//     public class BIGBOISOLUTIONWIDTK
//    {
//        public int bigboislotuion(int x )
//        {
//            HtmlWeb web = new HtmlWeb();
//            HtmlDocument doc = web.Load("https://www.worldometers.info/coronavirus/");

//            //Getting MainCounter 
//            //HtmlNode nodes= doc.DocumentNode.SelectNodes("//div[contains(@class,'maincounter-number')]//span").First();
//            HtmlNode[]nodes = doc.DocumentNode.SelectNodes("//tbody//tr//td").ToArray();

//            Dictionary<string, string> covidCases = new Dictionary<string, string>();


//            int a = int.Parse(nodes[154 + x].InnerText.Replace(",", ""));
//            return a;
//        }





//    }
//}
