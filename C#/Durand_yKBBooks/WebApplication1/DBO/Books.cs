using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DBO
{
    public class Books
    {
        //attribut
        private string _name;
        private string _isbn; 
        private string _author; 
        private string _number; 
        private string _dateback; 
        private string _id_lib; 

        #region getter/setter
        public string Name
        {
            get {return _name;}
            set {_name = value;}
        }

        public string Isbn 
        { 
            get {return _isbn;}
            set {_isbn = value;}
        }

        public string Author 
        { 
            get {return _author;}
            set {_author = value;}
        }

        public string Number
        {
            get {return _number;}
            set {_number = value;}
        }

        public string Dateback
        { 
            get {return _dateback;}
            set {_dateback = value}
        }

        public string IdLib 
        { 
            get {return _id_lib;}
            set {_id_lib = value}
        }
        #endregion

        public Books()
        {
            _name = "";
            _isbn = "";
            _author = "";
            _number = "";
            _dateback = "";
            _id_lib = "";
        }

        public Books(string name, string isbn, string author, string number, string dateback)
        {
            _name = name;
            _isbn = isbn;
            _author = author;
            _number = number;
            _dateback = dateback;
        }
    }
}