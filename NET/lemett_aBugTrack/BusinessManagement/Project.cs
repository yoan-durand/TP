using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lemett_aBugTrack.DataAccess;

namespace lemett_aBugTrack.BusinessManagement
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
            return DataAccess.Project.CreateProject(project);
        }

        /// <summary>
        /// permet de supprimer un projet
        /// </summary>
        /// <param name="id">id du projet</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteProject(long id)
        {
            return DataAccess.Project.DeleteProject(id);
        }

        /// <summary>
        /// permet de mettre  à jour le projet
        /// </summary>
        /// <param name="project">le projet a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateProject(T_Project project)
        {
            return DataAccess.Project.UpdateProject(project);
        }

        /// <summary>
        /// permet de récupérer un projet
        /// </summary>
        /// <param name="id">id du projet</param>
        /// <returns>le project si tout c'est bien passé sinon null</returns>
        public static T_Project GetProject(long id)
        {
            return DataAccess.Project.GetProject(id);

        }

        /// <summary>
        /// permet de récupérer un projet
        /// </summary>
        /// <param name="id">id du projet</param>
        /// <returns>le project si tout c'est bien passé sinon null</returns>
        public static T_Project GetProjectWithDetach(long id)
        {
            return DataAccess.Project.GetProject(id);

        }

        /// <summary>
        /// retourne la liste complete de tous les projects
        /// </summary>
        /// <returns>la liste des projects sinon une liste vide</returns>
        public static List<T_Project> GetListProject()
        {
            return DataAccess.Project.GetListProject();
        }
    }
}
