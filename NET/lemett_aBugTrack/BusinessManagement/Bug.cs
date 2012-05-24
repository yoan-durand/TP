using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lemett_aBugTrack.DataAccess;

namespace lemett_aBugTrack.BusinessManagement
{
    public class Bug
    {
        /// <summary>
        /// permet la création d'un bug
        /// </summary>
        /// <param name="bug">l'objet bug à crer</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool CreateBug(T_Bug bug, long idProject)
        {
            bug.CreateDate = DateTime.Now;
            return DataAccess.Bug.CreateBug(bug,idProject);
        }

        /// <summary>
        /// permet la création d'un bug critic
        /// </summary>
        /// <param name="bug">l'objet bug à crer</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool CreateBugCritic(T_BugCritic bug, long idProject)
        {
            bug.CreateDate = DateTime.Now;
            return DataAccess.Bug.CreateBug(bug,idProject);
        }

        /// <summary>
        /// permet la création d'un bug mineur
        /// </summary>
        /// <param name="bug">l'objet bug à crer</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool CreateBugMinor(T_BugMinor bug, long idProject)
        {
            bug.CreateDate = DateTime.Now;
            return DataAccess.Bug.CreateBug(bug, idProject);
        }

        /// <summary>
        /// permet la création d'un bug de typo
        /// </summary>
        /// <param name="bug">l'objet bug à crer</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool CreateBugTypo(T_BugTypo bug, long idProject)
        {
            bug.CreateDate = DateTime.Now;
            return DataAccess.Bug.CreateBug(bug, idProject);
        }

        /// <summary>
        /// permet de supprimer un bug
        /// </summary>
        /// <param name="id">id du bug</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteBug(long id)
        {
            return DataAccess.Bug.DeleteBug(id);
        }

        /// <summary>
        /// permet de mettre  à jour le bug
        /// </summary>
        /// <param name="bug">le bug a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateBug(T_Bug bug)
        {
            return DataAccess.Bug.UpdateBug(bug);
        }

        /// <summary>
        /// permet de récupérer un bug
        /// </summary>
        /// <param name="id">id du bug</param>
        /// <returns>le bug si tout c'est bien passé sinon null</returns>
        public static T_Bug GetBug(long id)
        {
            return DataAccess.Bug.GetBug(id);

        }

        /// <summary>
        /// retourne la liste complete de tous les bugs
        /// </summary>
        /// <returns>la liste des bugs sinon une liste vide</returns>
        public static List<T_Bug> GetListBug()
        {
            return DataAccess.Bug.GetListBug();
        }

        /// <summary>
        /// retourne la liste complete de tous les bugs
        /// </summary>
        /// <returns>la liste des bugs sinon une liste vide</returns>
        public static List<T_Bug> GetListBugWcf()
        {
            List<T_Bug> tmp = DataAccess.Bug.GetListBugWcf();

            foreach (T_Bug item in tmp)
            {
                if (!item.T_ProjectReference.IsLoaded)
                {
                    item.T_ProjectReference.Load();

                }

                if (!item.T_Transaction.IsLoaded)
                {
                    item.T_Transaction.Load();
                }
                if (item.T_Transaction.Count != 0 && !item.T_Transaction.First().T_UserReference.IsLoaded)
                {
                    item.T_Transaction.First().T_UserReference.Load();
                }
            }
            return tmp;
        }
    }
}
