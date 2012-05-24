using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.BusinessManagement
{
    public class GenerateDocx
    {
        public static bool GenerateReportBug (long idBug)
        {
            DBO.BugReport bugreport = new DBO.BugReport();
            DataAccess.Bug bug = new DataAccess.Bug();
            DataAccess.T_Bug b = bug.GetBug(idBug);
            List<DataAccess.T_Bug> li = bug.GetListBug();
            DataAccess.Comment com = new DataAccess.Comment();
            DataAccess.Transaction trans = new DataAccess.Transaction();
            List<DataAccess.T_Transaction> lt = trans.GetListTransaction();


            
            bugreport.Title = b.title;
            bugreport.Comment = com.getListCommentbyIdbug(idBug);
            foreach (DataAccess.T_Transaction item in lt)
            {
                if (item.T_Bug.id == idBug)
                {
                    bugreport.Statut = item.statut;
                    bugreport.Responsable = item.T_User.name + ' ' + item.T_User.firstname;
                    break;
                }
            }



            return (DataAccess.GenerateDocx.GenerateReportBug(bugreport) != null);
        }
    }
}