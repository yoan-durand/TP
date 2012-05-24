using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lemett_aBugTrack.DataAccess;
using lemett_aBugTrack.DBO;

namespace lemett_aBugTrack.BusinessManagement
{
    public class GenerateDocx
    {
        /// <summary>
        /// permet de générer un rapport de bug
        /// </summary>
        /// <param name="idBug">id du bug sur lequel on veut un report</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool GenerateReportBug(long idBug)
        {
            DBO.BugReport bugReport = new DBO.BugReport();
            T_Bug bug = BusinessManagement.Bug.GetBug(idBug);

            if (bug != null)
            {
                bugReport.Title = bug.title;

              
                //permet de remplir le type de bug
                switch (bug.GetType().Name)
                {
                    case "T_BugCritic":
                        bugReport.Type = "Critique";
                        break;

                    case "T_BugMinor":
                        bugReport.Type = "Mineur";
                        break;

                    case "T_BugTypo":
                        bugReport.Type = "Typo";
                        break;

                    default:
                        break;
                }

                

              //charge les tables d'après si elles ne sont pas encore dans l'objet
                if (!bug.T_Transaction.IsLoaded)
                    bug.T_Transaction.Load();
                T_Transaction trans = bug.T_Transaction.First();

                if (!trans.T_UserReference.IsLoaded)
                {
                    trans.T_UserReference.Load();    
                }
                

                bugReport.Responsable = trans.T_User.name;
                bugReport.Statut = ((EnumStatut)bug.T_Transaction.First().statut).ToString();

                if (!bug.T_Comment.IsLoaded)
                {
                    bug.T_Comment.Load();
                }

                foreach (T_Comment item in bug.T_Comment)
                {
                    
                    bugReport.Comments.Add(item.details);
                }
                DataAccess.GenerateDocx.GenerateReportBug(bugReport);

            }
            return true;
        }
    }
}
