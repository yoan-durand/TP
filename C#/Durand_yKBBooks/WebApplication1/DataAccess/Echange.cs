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
            string balise = "/Books/Book[";
            DBO.Books b = new DBO.Books ();
            List<DBO.Books> list = new List<DBO.Books>();
            XmlDocument xml = new XmlDocument ();
            int i = 0;

            xml.Load(filename);
            b.IdLib = xml.SelectSingleNode("/Books/@IDLibrary").InnerText;

            XmlNode node = xml.SelectSingleNode(balise+i.ToString ()+"]/");
            XmlNodeList nlist = xml.SelectNodes("/Books/*");

            list.Add(b);

            while (node.HasChildNodes)
            {
                list.Add (new DBO.Books(xml.SelectSingleNode(balise+i.ToString ()+"]/@name").InnerText, xml.SelectSingleNode(balise+i.ToString ()+"]/isbn").Value, xml.SelectSingleNode(balise+i.ToString ()+"]/author").Value,
                    xml.SelectSingleNode(balise+i.ToString ()+"]/number").Value, xml.SelectSingleNode(balise+i.ToString ()+"]/dateback").Value));
                i++;
                node = xml.SelectSingleNode(balise+i.ToString ()+"]/");
            }

            return (list);

        }

        public void create_DOM(List<DBO.Books> list)
        {
            XmlDocument xml = new XmlDocument();

            XmlDeclaration declaration = xml.CreateXmlDeclaration("1.0", "utf-8", null);
            xml.InsertBefore(declaration, xml.DocumentElement);

            XmlElement root = xml.CreateElement("Books");

            if (list.Count > 0)
            {
                root.SetAttribute("IDLibrary", list[0].IdLib);
            }

            XmlNode rootNode = xml.AppendChild (root);

            foreach (DBO.Books book in list)
            {
                XmlElement b = xml.CreateElement("Book");
                XmlElement isbn = xml.CreateElement("isbn");
                XmlElement author = xml.CreateElement("author");
                XmlElement number = xml.CreateElement("number");
                XmlElement date = xml.CreateElement("DateBack");

                b.SetAttribute("name", book.Name);
                isbn.Value = book.Isbn;
                author.Value = book.Author;
                number.Value = book.Number;
                date.Value = book.Dateback;

                XmlNode bookNode = rootNode.AppendChild(b);
                XmlNode IsbnNode = bookNode.AppendChild(isbn);
                XmlNode authorNode = bookNode.AppendChild(author);
                XmlNode numberNode = bookNode.AppendChild(number);
                XmlNode dateNode = bookNode.AppendChild(date);

            }

            xml.Save("KBBooks_Dom.xml");
        }
    }
}