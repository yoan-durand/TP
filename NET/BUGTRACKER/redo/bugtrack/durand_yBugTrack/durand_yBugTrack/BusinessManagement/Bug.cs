using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.BusinessManagement
{
    public class Bug
    {
        public static bool CreateBug(DataAccess.T_Bug bug, long idProject)
        {
            DataAccess.Bug b = new DataAccess.Bug();
            return (b.CreateBug(bug, idProject));
        }

        public static bool DeleteBug(long id)
        {
            DataAccess.Bug b = new DataAccess.Bug();
            return (b.DeleteBug(id));
        }

        public static bool UpdateBug(DataAccess.T_Bug bug)
        {
            DataAccess.Bug b = new DataAccess.Bug();
            return (b.UpdateBug(bug));

        }

        public static DataAccess.T_Bug GetBug(long id)
        {
            DataAccess.Bug b = new DataAccess.Bug();
            return (b.GetBug(id));
        }

        public static List<DataAccess.T_Bug> GetListBug()
        {
            DataAccess.Bug b = new DataAccess.Bug();
            return (b.GetListBug());
        }
    }
}