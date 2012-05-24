using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class User
    {
        public static string getName(long idUser)
        {
            DataAccess.User user = new DataAccess.User();

            return (user.getName(idUser));
        }
    }
}