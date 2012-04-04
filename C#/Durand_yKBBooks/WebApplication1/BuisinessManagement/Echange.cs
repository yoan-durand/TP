using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WebApplication1.BuisinessManagement
{
    public class Echange
    {
        private string _id_lib { get; set; }
        public Echange()
        {
        }

        public List<DBO.Books> parseDom (string filename)
        {
            string balise = "/Books/Book["
            DBO.Books b = new DBO.Books ();
            List<DBO.Books> list = new List<DBO.Books>();
            XmlDocument xml = new XmlDocument ();
            int i = 0;

            xml.Load(filename);
            b.IdLib = xml.SelectSingleNode("/Books/@IDLibrary").InnerText;

            XmlNode node = xml.SelectSingleNode(balise+i.ToString ()+"]/");
            XmlNodeList nlist = xml.SelectNodes("/Books/*");


            while (node.HasChildNodes)
            {
                list.Add (new DBO.Books(xml.SelectSingleNode(balise+i.ToString ()+"]/@name").InnerText, xml.SelectSingleNode(balise+i.ToString ()+"]/isbn").Value, xml.SelectSingleNode(balise+i.ToString ()+"]/author").Value,
                    xml.SelectSingleNode(balise+i.ToString ()+"]/number").Value, xml.SelectSingleNode(balise+i.ToString ()+"]/dateback").Value));
                i++;
                node = xml.SelectSingleNode(balise+i.ToString ()+"]/");
            }

            return (list);

        }
    }
}