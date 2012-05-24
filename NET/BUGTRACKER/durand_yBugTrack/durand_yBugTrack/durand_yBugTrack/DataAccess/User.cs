using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Objects;

namespace durand_yBugTrack.DataAccess
{
    public class User
    {
        public bool CreateUser(T_User user)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities ())
            {
               ObjectResult<T_User> us = bugtrack.CreateUser(user.name, user.firstname, user.email, user.phone, user.password);
               
                if (us != null)
                {
                    return true;
                }
                return false;

            }
        }

        public bool DeleteUser(long id)
        {
           using ( BugTrackLikeEntities bugtrack = new BugTrackLikeEntities ())
           {
               ObjectResult<T_User> user = bugtrack.DeleteUser(id);

               if (user != null)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
        }


        public bool UpdateUser(T_User user)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities ())
            {
                ObjectResult<T_User> us = bugtrack.UpdateUser(user.id, user.email, user.phone, user.password);
                if (us != null)
                {
                    return true;
                }
                return false;
            }
        }

        public T_User GetUser(long id)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                T_User trans = bugtrack.T_User.Where(t => t.id == id).FirstOrDefault();

                if (trans != null)
                {
                    return (trans);
                }

                return null;
            }
        }

        public List<T_User> GetListUser()
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                List<T_User> list = bugtrack.T_User.ToList();
                return (list);
            }
        }
    }
}