using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyndicationServiceBugTrack.DBO
{
    public class Bug
    {
        #region variables
        private string _title;
        private string _projectName;
        private DateTime _createDate;
        private string _details;
        #endregion


        #region getter / setter
        /// <summary>
        /// détails du bug
        /// </summary>
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        /// <summary>
        /// date de creation du bug
        /// </summary>
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        /// <summary>
        /// nom du projet
        /// </summary>
        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        /// <summary>
        /// titre du bug
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        } 
        #endregion

        public Bug()
        {
            _title = "";
            _projectName = "";
            _createDate = DateTime.Now;
            _details = "";
        }
    }
}
