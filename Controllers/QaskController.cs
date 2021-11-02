using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AllinDigitalTools.Models;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace AllinDigitalTools.Controllers
{
    public class QaskController : Controller
    {
        public IActionResult Index()
        {
            String URLString = "http://google.com/complete/search?output=toolbar&gl=eg&q=digital";

            string name;
            XmlDocument xml = new XmlDocument();
            xml.Load(URLString);
            // Or any other method to load your xml data in the XmlDocument.
            // For example if your xml data are in a string, use the LoadXml method.
            XmlElement elt = xml.SelectSingleNode("/toplevel/CompleteSuggestion/suggestion ") as XmlElement;
            if (elt != null)
            {
                name = elt.GetAttribute("data");
                Console.WriteLine(name);

            }





            // String urlnameN = "http://google.com/complete/search?output=toolbar&gl=eg&q=";
            // Srting q = "are","can","how","what","when","where","which","who","why","will"


            // XDocument X = XDocument.Load("http://www.yr.no/place/Norway/Oslo/Oslo/Oslo/forecast.xml");
            // var forecast = X.Element("weatherdata").Element("forecast");
            // var location = forecast.Descendants("location").Attributes("name").FirstOrDefault().Value;
            // var tempData = forecast.Element("tabular").Elements("time");




            //This is what you need
            // var data = tempData.Select(item =>
            //             new
            //             {
            //                 from = Convert.ToDateTime(item.Attribute("from").Value),
            //                 to = Convert.ToDateTime(item.Attribute("to").Value),
            //                 temp = item.Element("temperature").Attribute("value").Value
            //             });

            //                 ViewBag.urlname = data;
            // Console.WriteLine(data.temp.typeOf());
            //Or you can do a foreach if you need to
            // foreach (var item in tempData)
            // {
            //     DateTime from = Convert.ToDateTime(item.Attribute("from").Value);
            //     var temp = item.Element("temperature").Attribute("unit").Value;

            // }





            return View();
        }



    }
}
