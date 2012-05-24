using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace lemett_aBugTrack
{
    // NOTE: If you change the class name "ServiceClientBugTrack" here, you must also update the reference to "ServiceClientBugTrack" in Web.config.
    public class ServiceClientBugTrack : IServiceClientBugTrack
    {
        public List<DBO.BugTransfert> GetListBug(int max)
        {
            List<DBO.BugTransfert> list = new List<lemett_aBugTrack.DBO.BugTransfert>();
            List<DataAccess.T_Bug> tmplist = BusinessManagement.Bug.GetListBug().OrderBy(x=>x.CreateDate).Take(max).ToList();

            foreach (DataAccess.T_Bug item in tmplist)
            {
                //creation du bug
                DBO.BugTransfert bug = new lemett_aBugTrack.DBO.BugTransfert()
                {
                    CreateDate = item.CreateDate,
                    Title = item.title
                };

                if (!item.T_ProjectReference.IsLoaded)
                {
                    item.T_ProjectReference.Load();
                }
                bug.ProjectName = item.T_Project.name;
                if (!item.T_Transaction.IsLoaded)
                {
                    item.T_Transaction.Load();
                }
                if (!item.T_Transaction.First().T_UserReference.IsLoaded)
                {
                    item.T_Transaction.First().T_UserReference.Load();
                }
                bug.Responsable = item.T_Transaction.First().T_User.name;
                list.Add(bug);
            }


            return  list;
        }

        public List<DataAccess.T_Bug> GetListBugWithEF(int max)
        {
            return BusinessManagement.Bug.GetListBugWcf().OrderBy(x=>x.CreateDate).Take(max).ToList();
        }
    }
}
