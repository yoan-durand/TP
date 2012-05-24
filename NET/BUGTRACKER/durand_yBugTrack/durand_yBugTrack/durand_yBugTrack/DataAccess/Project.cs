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
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
               
                bugtrack.AddToT_Project(project);
                bugtrack.SaveChanges();

                var test = from b in bugtrack.T_Project
                           where b.Id == project.Id
                           select b;

                return (test.Count() > 0);
            }
        }

        public bool DeleteProject(long id)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities ())
            {
                bugtrack.DeleteObject(bugtrack.T_Project.Where(p => p.Id == id).FirstOrDefault());
                bugtrack.SaveChanges();

                var test = from b in bugtrack.T_Project
                           where b.Id == id
                           select b;

                return (test.Count() == 0);
            }
        }

        public bool UpdateProject(T_Project project)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                T_Project proj = bugtrack.T_Project.Where(p => p.Id == project.Id).FirstOrDefault();

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
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                T_Project com = bugtrack.T_Project.Where(c => c.Id == id).FirstOrDefault();

                if (com != null)
                {
                    return (com);
                }

                return null;
            }
        }

        public List<T_Project> GetListProject()
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                List<T_Project> list = bugtrack.T_Project.ToList();
                return (list);
            }
        }
    }
}