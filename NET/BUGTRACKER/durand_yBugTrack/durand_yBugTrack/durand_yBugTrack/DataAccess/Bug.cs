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
            BugTrackLikeEntities1 bugtrack = new BugTrackLikeEntities1();
            T_Bug newBug = new T_Bug();

            newBug.id = bug.id;
            newBug.T_Project.Id = idProject;
            newBug.title = bug.title;
            newBug.Type = bug.Type;
            newBug.Createdate = bug.Createdate;
            bugtrack.AddToT_Bug(newBug);
            bugtrack.SaveChanges();

            var test = from b in bugtrack.T_Bug
                       where b.id == bug.id
                       select b;

            return (test.Count() > 0);
        }

        public bool DeleteBug(long id)
        {
            BugTrackLikeEntities1 bugtrack = new BugTrackLikeEntities1();
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

        public bool UpdateBug(T_Bug bug)
        {
            using (BugTrackLikeEntities1 bugtrack = new BugTrackLikeEntities1 ())
            {
                T_Bug b = bugtrack.T_Bug.Where(r => r.id == bug.id).FirstOrDefault();
                if (b != null)
                {
                    b.title = bug.title;
                    b.T_Project.Id = bug.T_Project.Id;
                    b.Type = bug.Type;
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
            BugTrackLikeEntities1 bugtrack = new BugTrackLikeEntities1 ();
            var bug = from b in bugtrack.T_Bug
                      where b.id == id
                      select b;
            T_Bug res = (T_Bug) bug;
            return res;
        }

        public List<T_Bug> GetListBug()
        {
            BugTrackLikeEntities1 bugtrack = new BugTrackLikeEntities1();
            List<T_Bug> list = bugtrack.T_Bug.ToList();
            return (list);
        }
    }
}