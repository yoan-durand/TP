using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lemett_aBugTrack.DBO
{
    public class BugReport
    {
        #region variables
        private string _title;
        private string _type;
        private string _responsable;
        private string _statut;
        private List<string> _comments;
        #endregion

        #region getter / setter
        /// <summary>
        /// commentaire des bugs
        /// </summary>
        public List<string> Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        /// <summary>
        /// statut du bug
        /// </summary>
        public string Statut
        {
            get { return _statut; }
            set { _statut = value; }
        }

        /// <summary>
        /// responsable du bug
        /// </summary>
        public string Responsable
        {
            get { return _responsable; }
            set { _responsable = value; }
        }

        /// <summary>
        /// titre du bug
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// type du bug
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        #endregion

        public BugReport()
        {
            _comments = new List<string>();
            _responsable = "";
            _statut = "";
            _title = "";
            _type = "";

        }
    }
}
