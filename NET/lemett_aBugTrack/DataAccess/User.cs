using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lemett_aBugTrack.DataAccess
{
    public class User
    {
        /// <summary>
        /// permet la création d'un utilisateur
        /// </summary>
        /// <param name="user">l'objet utilisateur à crer</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool CreateUser(T_User user)
        {
            try
            {

                BugTrackEntities model = new BugTrackEntities();
                model.AddToT_User(user);
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// permet de supprimer un utilisateur
        /// </summary>
        /// <param name="id">id de l'utilisateur</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteUser(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                model.DeleteObject(model.T_User.Where(x => x.id == id).FirstOrDefault());
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// permet de mettre  à jour l'utilisateur
        /// </summary>
        /// <param name="user">l'utilisateur a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateUser(T_User user)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                T_User userDB = model.T_User.Where(x => x.id == user.id).FirstOrDefault();
                if (userDB != null)
                {
                    userDB.email = user.email;
                    userDB.firstname = user.firstname;
                    userDB.name = user.name;
                    userDB.password = user.password;
                    userDB.phone = user.phone;

                    model.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// permet de récupérer un utilisateur
        /// </summary>
        /// <param name="id">id de l'utilisateur</param>
        /// <returns>l'user si tout c'est bien passé sinon null</returns>
        public static T_User GetUser(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_User.Where(x => x.id == id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// retourne la liste complete de tous les users
        /// </summary>
        /// <returns>la liste des users sinon une liste vide</returns>
        public static List<T_User> GetListUser()
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_User.ToList();
            }
            catch (Exception ex)
            {
                return new List<T_User>();
            }
        }
    }
}
