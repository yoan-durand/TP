using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace WebApplication1.DataAccess
{
    public class Echange
    {
        private string _id_lib { get; set; }

        public List<DBO.Books> parseDom (string filename)
        {
            string balise = "/Books/book[";
            DBO.Books b = new DBO.Books ();
            List<DBO.Books> list = new List<DBO.Books>();
            XmlDocument xml = new XmlDocument ();
            int i = 1;
            xml.Load(XmlReader.Create("file:///"+System.Web.HttpContext.Current.Server.MapPath("~/")+"/" +filename));
            b.IdLib = xml.SelectSingleNode("/Books/@IDLibrary").InnerText;
            string xpath = balise + i.ToString() + "]";
            XmlNode node = xml.SelectSingleNode(xpath);

            list.Add(b);
            if (node != null)
            {
                while ((node != null) && (node.HasChildNodes))
                {
                    list.Add(new DBO.Books(xml.SelectSingleNode(xpath + "/@name").InnerText, xml.SelectSingleNode(xpath + "/isbn").InnerText, xml.SelectSingleNode(xpath + "/author").InnerText,
                        xml.SelectSingleNode(xpath + "/number").InnerText, xml.SelectSingleNode(xpath + "/DateBack").InnerText));
                    i++;
                    xpath = balise + i.ToString() + "]";
                    node = xml.SelectSingleNode(xpath);
                }
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
                if (book.IdLib == null)
                {
                    XmlElement b = xml.CreateElement("book");
                    XmlElement isbn = xml.CreateElement("isbn");
                    XmlElement author = xml.CreateElement("author");
                    XmlElement number = xml.CreateElement("number");
                    XmlElement date = xml.CreateElement("DateBack");

                    b.SetAttribute("name", book.Name);
                    isbn.InnerText = book.Isbn;
                    author.InnerText = book.Author;
                    number.InnerText = book.Number;
                    date.InnerText = book.Dateback;

                    XmlNode bookNode = rootNode.AppendChild(b);
                    XmlNode IsbnNode = bookNode.AppendChild(isbn);
                    XmlNode authorNode = bookNode.AppendChild(author);
                    XmlNode numberNode = bookNode.AppendChild(number);
                    XmlNode dateNode = bookNode.AppendChild(date);
                }

            }

            xml.Save(System.Web.HttpContext.Current.Server.MapPath("~/")+"/" + "KBBooks_Dom.xml");
        }


        public List<DBO.Books> parse_linq(string filename)
        {
            List<DBO.Books> list = new List<DBO.Books>();
            XDocument xdoc = XDocument.Load(XmlReader.Create("file:///"+System.Web.HttpContext.Current.Server.MapPath("~/")+"/" +filename));
            var id = from lib in xdoc.Descendants("Books")
                     where (string)lib.Attribute("IDLibrary") != ""
                     select lib;

            var b = from book in xdoc.Descendants("book")
                    select book;  
                        
            DBO.Books first = new DBO.Books();
            foreach (XElement l_id in id)
            {
                first.IdLib = (string) l_id.Attribute("IDLibrary");   
            }
            list.Add(first);

            foreach (XElement books in b)
            {
                string name = (string)books.Attribute("name");
                string isbn = books.Element("isbn").Value;
                string author = books.Element("author").Value;
                string number = books.Element("number").Value;
                string date = books.Element("DateBack").Value;
                list.Add(new DBO.Books(name, isbn, author, number, date));
                Console.WriteLine(books);
            }

            return list;
        }

        public void create_linq(List<DBO.Books> list)
        {

            XElement xml = new XElement("Books",new XAttribute ("IDLibrary", list[0].IdLib));
            XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), xml);

            foreach (DBO.Books book in list)
            {
                if (book.IdLib == null)
                {
                    XElement elt = new XElement( "book",new XAttribute ("name", book.Name), new XElement("isbn", book.Isbn), new XElement ("author", book.Author),
                      new XElement ("number", book.Number), new XElement("DateBack", book.Dateback));
                    xdoc.Element("Books").Add(elt);
                }
            }

            xdoc.Save(System.Web.HttpContext.Current.Server.MapPath("~/")+"/" +"Books_linQ.xml");

        }
    }
}