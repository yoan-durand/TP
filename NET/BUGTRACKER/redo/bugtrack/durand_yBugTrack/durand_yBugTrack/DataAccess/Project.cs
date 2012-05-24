using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.DataAccess
{
    public class Project
    {
        public bool CreateProject(T_Project project)
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {

                bugtrack.AddToT_Project(project);
                bugtrack.SaveChanges();

                var test = from b in bugtrack.T_Project
                           where b.id == project.id
                           select b;

                return (test.Count() > 0);
            }
        }

        public bool DeleteProject(long id)
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                bugtrack.DeleteObject(bugtrack.T_Project.Where(p => p.id == id).FirstOrDefault());
                bugtrack.SaveChanges();

                var test = from b in bugtrack.T_Project
                           where b.id == id
                           select b;

                return (test.Count() == 0);
            }
        }

        public bool UpdateProject(T_Project project)
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                T_Project proj = bugtrack.T_Project.Where(p => p.id == project.id).FirstOrDefault();

                if (proj != null)
                {
                    proj = project;
                    bugtrack.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public T_Project GetProject(long id)
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                T_Project com = bugtrack.T_Project.Where(c => c.id == id).FirstOrDefault();

                if (com != null)
                {
                    return (com);
                }

                return null;
            }
        }

        public List<T_Project> GetListProject()
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                List<T_Project> list = bugtrack.T_Project.ToList();
                return (list);
            }
        }
    }
}