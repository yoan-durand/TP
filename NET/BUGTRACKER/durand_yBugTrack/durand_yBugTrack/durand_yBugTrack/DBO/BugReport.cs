using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.DBO
{
    public class BugReport
    {
        private string _title;
        private string _type;
        private string _responsable;
        private string _statut;
        private List<string> _comment;

        #region getter/setter
        public string Title 
        {
            get { return _title; }
            set { _title = value; }
        }


        public string Type 
        {
            get {return _type; }
            set { _type = value; }
        }

        public string Responsable 
        {
            get {return _responsable;}
            set { _responsable = value; }
        }

        public string  Statut 
        {
            get {return _statut; }
            set { _statut = value; }
        }

        public List<string> Comment 
        {
            get { return _comment; }
            set { _comment = value;  }
        }
        #endregion

        public BugReport()
        {
        }
    }
}