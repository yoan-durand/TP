using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lemett_aBugTrack.DataAccess
{
    public class Project
    {
        /// <summary>
        /// permet la création d'un projet
        /// </summary>
        /// <param name="project">l'objet project à crer</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool CreateProject(T_Project project)
        {
            try
            {

                BugTrackEntities model = new BugTrackEntities();
                model.AddToT_Project(project);
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { 
                return false;
            }
        }

        /// <summary>
        /// permet de supprimer un projet
        /// </summary>
        /// <param name="id">id du projet</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteProject(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                model.DeleteObject(model.T_Project.Where(x => x.id == id).FirstOrDefault());
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// permet de mettre  à jour le projet
        /// </summary>
        /// <param name="project">le projet a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateProject(T_Project project)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                T_Project projectDB = model.T_Project.Where(x => x.id == project.id).FirstOrDefault();
                if (projectDB != null)
                {
                    projectDB.name = project.name;
                    projectDB.startDate = project.startDate;
                    projectDB.version = project.version;

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
        /// permet de récupérer un projet
        /// </summary>
        /// <param name="id">id du projet</param>
        /// <returns>le project si tout c'est bien passé sinon null</returns>
        public static T_Project GetProject(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_Project.Where(x => x.id == id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// permet de récupérer un projet
        /// </summary>
        /// <param name="id">id du projet</param>
        /// <returns>le project si tout c'est bien passé sinon null</returns>
        public static T_Project GetProjectWithDetach(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                T_Project project =  model.T_Project.Where(x => x.id == id).FirstOrDefault();
                model.Detach(project);
                return project;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// retourne la liste complete de tous les projects
        /// </summary>
        /// <returns>la liste des projects sinon une liste vide</returns>
        public static List<T_Project> GetListProject()
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_Project.ToList();
            }
            catch (Exception ex)
            {
                return new List<T_Project>();
            }
        }
    }
}
