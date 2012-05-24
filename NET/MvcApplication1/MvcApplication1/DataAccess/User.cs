using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataAccess
{
    public class User
    {
        public string getName(long idUser)
        {
            string str = "";

            using (DebugBASEEntities debug = new DebugBASEEntities())
            {
                T_User user = debug.T_User.Where(u => u.id == idUser).FirstOrDefault();

                str = user.nom;
            }
            return str;
        }
    }
}