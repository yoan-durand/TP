using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace lemett_aBugTrack.DBO
{
    /// <summary>
    /// rajout de l'attribut datacontract pour spécifier que la classe va passer
    /// par WCF
    /// on met datamember pour toutes les
    /// propriétés que l'on veut transmettre
    /// </summary>
    [DataContract]
    public class BugTransfert
    {
        #region variables
        private string _responsable;
        private string _title;
        private string _projectName;
        private DateTime _createDate;
        #endregion

        #region getter / setter
        
        /// <summary>
        /// responsable du bug
        /// </summary>
        [DataMember]
        public string Responsable
        {
            get { return _responsable; }
            set { _responsable = value; }
        }

        /// <summary>
        /// titre du bug
        /// </summary>
        [DataMember]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// nom du projet
        /// </summary>
        [DataMember]
        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        /// <summary>
        /// date de creation
        /// </summary>
        [DataMember]
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }
        #endregion

        public BugTransfert()
        {
            _responsable = "";

            _title = "";
            _projectName = "";
            _createDate = DateTime.Now;
        }
    }
}
