using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientBugTrack.BusinessManagement
{
    public class BugTrack
    {
        public static List<ServiceReferenceBugTrack.BugTransfert> GetListBug(int max)
        {
            DataAccess.BugTrack dataAccess = new ClientBugTrack.DataAccess.BugTrack();
            return dataAccess.GetListBug(max);
        }

        public static List<ServiceReferenceBugTrack.T_Bug> GetListBugWithEF(int max)
        {
            DataAccess.BugTrack dataAccess = new ClientBugTrack.DataAccess.BugTrack();
            return dataAccess.GetListBugWithEF(max);
        }
    }
}
