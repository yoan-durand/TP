using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyndicationServiceBugTrack.DBO
{
    class Bug
    {
        private string _title;
        private string _projectName;
        private DateTime _createDate;
        private string _details;

        public string Title 
        {
            get { return _title; }
            set { _title = value; }
        }

        public string ProjectName 
        {
            get { return _projectName; }
            set { _projectName = value; } 
        }

        public DateTime CreateDate 
        {
            get { return _createDate; }
            set { _createDate = value; } 
        }

        public string Details 
        { 
            get {return _details;}
            set { _details = value; }
        }
    }
}