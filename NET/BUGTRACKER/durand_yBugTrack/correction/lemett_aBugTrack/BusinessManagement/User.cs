using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lemett_aBugTrack.DataAccess;

namespace lemett_aBugTrack.BusinessManagement
{
    
    /// <summary>
    /// Attention ici on passe des objets de la dataAccess car notre DBO est
    /// contenue dans notre model ..
    /// </summary>
    public class User
    {
        /// <summary>
        /// permet la création d'un utilisateur
        /// </summary>
        /// <param name="user">l'objet utilisateur à crer</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool CreateUser(T_User user)
        {
            return DataAccess.User.CreateUser(user);
        }

        /// <summary>
        /// permet de supprimer un utilisateur
        /// </summary>
        /// <param name="id">id de l'utilisateur</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteUser(long id)
        {
            return DataAccess.User.DeleteUser(id);
        }

        /// <summary>
        /// permet de mettre  à jour l'utilisateur
        /// </summary>
        /// <param name="user">l'utilisateur a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateUser(T_User user)
        {
            return DataAccess.User.UpdateUser(user);
        }

        /// <summary>
        /// permet de récupérer un utilisateur
        /// </summary>
        /// <param name="id">id de l'utilisateur</param>
        /// <returns>l'user si tout c'est bien passé sinon null</returns>
        public static T_User GetUser(long id)
        {
            return DataAccess.User.GetUser(id);

        }

        /// <summary>
        /// permet de récupérer un utilisateur
        /// </summary>
        /// <param name="id">nom de l'utilisateur</param>
        /// <returns>l'user si tout c'est bien passé sinon null</returns>
        public static T_User GetUser(string name)
        {
            return DataAccess.User.GetUser(name);

        }

        /// <summary>
        /// retourne la liste complete de tous les users
        /// </summary>
        /// <returns>la liste des users sinon une liste vide</returns>
        public static List<T_User> GetListUser()
        {
            return DataAccess.User.GetListUser();
        }
    }
}
