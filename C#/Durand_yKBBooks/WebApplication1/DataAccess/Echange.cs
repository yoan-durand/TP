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
            int i = 0;

            xml.Load(filename);
            b.IdLib = xml.SelectSingleNode("/Books/@IDLibrary").InnerText;

            XmlNode node = xml.SelectSingleNode(balise+i.ToString ()+"]/");

            list.Add(b);

            while (node.HasChildNodes)
            {
                list.Add (new DBO.Books(xml.SelectSingleNode(balise+i.ToString ()+"]/@name").InnerText, xml.SelectSingleNode(balise+i.ToString ()+"]/isbn").Value, xml.SelectSingleNode(balise+i.ToString ()+"]/author").Value,
                    xml.SelectSingleNode(balise+i.ToString ()+"]/number").Value, xml.SelectSingleNode(balise+i.ToString ()+"]/DateBack").Value));
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
                if (book.IdLib.Equals(""))
                {
                    XmlElement b = xml.CreateElement("book");
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
                }

            }

            xml.Save("KBBooks_Dom.xml");
        }


        public List<DBO.Books> parse_linq(string filename)
        {
            List<DBO.Books> list = new List<DBO.Books>();
            XDocument xdoc = XDocument.Load(filename);
            var id = from lib in xdoc.Descendants("Books")
                     where (string)lib.Attribute("IDLibrary") != ""
                     select lib;

            var b = from book in xdoc.Descendants("Books")
                        select new 
                        {      
                          Name = (string) book.Element("book").Attribute("name"),
                          Isbn = book.Element("isbn").Value,
                          Author = book.Element("author").Value,
                          Number = book.Element("number").Value,
                          DateBack = book.Element("DateBack").Value
                        };
            DBO.Books first = new DBO.Books();
            foreach (XElement l_id in id)
            {
                first.IdLib = (string) l_id.Attribute("IDLibrary");   
            }
            list.Add(first);

            foreach (var books in b)
            {
                list.Add(new DBO.Books(books.Name, books.Isbn, books.Author, books.Number, books.DateBack));
            }

            return list;
        }

        public void create_linq(List<DBO.Books> list)
        {

            XElement xml = new XElement("Books",new XAttribute ("IDLibrary", list[0].IdLib));
            XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), xml);

            foreach (DBO.Books book in list)
            {
                XElement elt = new XElement( "book",new XAttribute ("name", book.Name), new XElement("isbn", book.Isbn), new XElement ("author", book.Author),
                    new XElement ("number", book.Number), new XElement("DateBack", book.Dateback));
                xdoc.Element("Books").Add(elt);
            }

            xdoc.Save("Books_linQ.xml");

        }
    }
}