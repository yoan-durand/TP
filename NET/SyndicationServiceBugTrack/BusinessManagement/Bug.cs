using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyndicationServiceBugTrack.BusinessManagement
{
    class Bug
    {
        public static List<DBO.Bug> GetLastBug(int max)
        {
            List<DBO.Bug> list = new List<DBO.Bug>();
            DataAccess.Bug bl = new DataAccess.Bug();

            foreach (DataAccess.T_Bug b in bl.GetLastBug(max))
            {
                DBO.Bug bug = new DBO.Bug();
                bug.Title = b.title;
                bug.Details = b.Description;
                bug.CreateDate = b.Createdate;
                bug.ProjectName = b.T_Project.name;

                list.Add(bug);
            }


            return list;
        }
    }
}
