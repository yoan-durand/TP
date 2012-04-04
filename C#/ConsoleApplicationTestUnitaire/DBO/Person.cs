using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationTestUnitaire.DBO
{
    public class Person
    {
        #region variables
        /// <summary>
        /// nom de la personne
        /// </summary> 
        private string _name;

        private string _firstname;

        /// <summary> 
        /// adresse de la personne
        /// </summary>
        private string _address;

        ///<summary> 
        ///fonction de la personne
        ///</summary> 
        private string _function;

        #endregion
        #region getter / setter
        ///<summary> 
        ///accès à la focntion de la personne 
        ///</summary>

        public string Function { get { return _function; } set { _function = value; } }
        /// <summary> 
        /// accès au prénom de la personne 
        /// </summary>

        public string Firstname { get { return _firstname; } set { _firstname = value; } }

               public string Address { get { return _address; } set { _address = value; } }

        /// <summary>
        /// accès au nom de la personne 
        /// </summary> 
        public string Name { get { return _name; } set { _name = value; } }

        #endregion

        /// <summary> 
        /// constructeur de la classe 
        /// </summary> 
        public Person() { _name = ""; _firstname = ""; _address = ""; _function = ""; }
    }
}
