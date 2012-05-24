using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            return DataAccess.User.GetListUser();
        }

        public static List<Models.UserItem> getlist()
        {
            List<DataAccess.T_User> list = DataAccess.User.GetListUser();
            List<Models.UserItem> listuseritem = new List<Models.UserItem>();
            foreach (DataAccess.T_User user in list)
            {
                Models.UserItem useritem = new Models.UserItem()
                {
                    Name = user.name,
                    Firstname = user.firstname,
                    Mail = user.firstname,
                    Password = user.password,
                    Phone = user.phone
                };
                listuseritem.Add(useritem);
            }
            return listuseritem;
        }
    }
}