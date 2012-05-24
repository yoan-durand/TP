using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lemett_aBugTrack.DataAccess
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
            try
            {

                BugTrackEntities model = new BugTrackEntities();

                bug.T_Project = model.T_Project.Where(x => x.id == idProject).FirstOrDefault();

                //model.Attach(bug.T_Project);
                model.AddToT_Bug(bug);
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// permet de supprimer un bug
        /// </summary>
        /// <param name="id">id du bug</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteBug(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                model.DeleteObject(model.T_Bug.Where(x => x.id == id).FirstOrDefault());
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// permet de mettre  à jour le bug
        /// </summary>
        /// <param name="bug">le bug a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateBug(T_Bug bug)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                T_Bug bugDB = model.T_Bug.Where(x => x.id == bug.id).FirstOrDefault();
                if (bugDB != null)
                {
                    bugDB.title = bug.title;
                 
                    
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
        /// permet de récupérer un bug
        /// </summary>
        /// <param name="id">id du bug</param>
        /// <returns>le bug si tout c'est bien passé sinon null</returns>
        public static T_Bug GetBug(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                model.T_Transaction.Include("T_User");
                model.T_Bug.Include("T_Project");
                
                return model.T_Bug.Where(x => x.id == id).FirstOrDefault();
                
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// retourne la liste complete de tous les bugs
        /// </summary>
        /// <returns>la liste des bugs sinon une liste vide</returns>
        public static List<T_Bug> GetListBug()
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_Bug.ToList();
            }
            catch (Exception ex)
            {
                return new List<T_Bug>();
            }
        }

        /// <summary>
        /// retourne la liste complete de tous les bugs
        /// </summary>
        /// <returns>la liste des bugs sinon une liste vide</returns>
        public static List<T_Bug> GetListBugWcf()
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                List<T_Bug> tmp = model.T_Bug.ToList();
                return tmp; 
            }
            catch (Exception ex)
            {
                return new List<T_Bug>();
            }
        }
    }
}
