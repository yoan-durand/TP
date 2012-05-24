using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.DataAccess
{
    public class Bug
    {
        public bool CreateBug(T_Bug bug, long idProject)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                bug.T_Project.Id = idProject;
                bugtrack.AddToT_Bug(bug);
                bugtrack.SaveChanges();

                var test = from b in bugtrack.T_Bug
                           where b.id == bug.id
                           select b;

                return (test.Count() > 0);
            }
        }

        public bool DeleteBug(long id)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                var bug = from b in bugtrack.T_Bug
                          where b.id == id
                          select b;
                var res = bug.FirstOrDefault();

                if (res != null)
                {
                    bugtrack.DeleteObject(res);
                    bugtrack.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
        }

        public bool UpdateBug(T_Bug bug)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities ())
            {
                T_Bug b = bugtrack.T_Bug.Where(r => r.id == bug.id).FirstOrDefault();
                if (b != null)
                {
                    b.title = bug.title;
                    b.T_Project.Id = bug.T_Project.Id;
                    b.Createdate = bug.Createdate;
                    bugtrack.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public T_Bug GetBug(long id)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                T_Bug bug = bugtrack.T_Bug.Where(b => b.id == id).FirstOrDefault();
                return bug;
            }
        }


        
        public List<T_Bug> GetListBug()
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                List<T_Bug> list = bugtrack.T_Bug.ToList();
                return (list);
            }
        }
    }
}