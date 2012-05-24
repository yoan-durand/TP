using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using durand_yBugTrack.DataAccess;

namespace durand_yBugTrack.BusinessManagement
{
    public class User
    {
        public bool CreateUser(DataAccess.T_User user)
        {
            DataAccess.User u = new DataAccess.User();

            return u.CreateUser(user);
        }

        public bool DeleteUser(long id)
        {
            DataAccess.User u = new DataAccess.User();

            return u.DeleteUser(id);
        }


        public bool UpdateUser(DataAccess.T_User user)
        {
            DataAccess.User u = new DataAccess.User();

            return u.UpdateUser(user);
        }

        public DataAccess.T_User GetUser(long id)
        {
            DataAccess.User u = new DataAccess.User();

            return u.GetUser(id);
        }

        public List<DataAccess.T_User> GetListUser()
        {
            DataAccess.User u = new DataAccess.User();

            return u.GetListUser();
        }
    }
}