using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyndicationServiceBugTrack.DataAccess
{
    class Bug
    {
        public List<T_Bug> GetLastBug(int max)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                List<T_Bug> list = new List<T_Bug>();
                DateTime today = DateTime.Now;

                List<T_Bug> lb = bugtrack.T_Bug.OrderBy(r => r.Createdate).ToList();

                for (int i = 0; i < max; i++)
                {
                    list.Add(lb[i]);   
                }

                return list;
            }
        }



    }
}
