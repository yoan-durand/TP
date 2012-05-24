using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.BusinessManagement
{
    public class Project
    {
        public bool CreateProject(DataAccess.T_Project project)
        {
            DataAccess.Project proj = new DataAccess.Project();

            return proj.CreateProject(project);
        }

        public bool DeleteProject(long id)
        {
            DataAccess.Project proj = new DataAccess.Project();

            return proj.DeleteProject(id);
        }

        public bool UpdateProject(DataAccess.T_Project project)
        {
            DataAccess.Project proj = new DataAccess.Project();

            return proj.UpdateProject(project);


        }

        public DataAccess.T_Project GetProject(long id)
        {
            DataAccess.Project proj = new DataAccess.Project();

            return proj.GetProject(id);
        }

        public List<DataAccess.T_Project> GetListProject()
        {
            DataAccess.Project proj = new DataAccess.Project();

            return proj.GetListProject();
        }
    }
}