using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyndicationServiceBugTrack.BusinessManagement
{
    public class Bug
    {
        public static List<DBO.Bug> GetLastBug(int max)
        {
            List<DBO.Bug> list = new List<SyndicationServiceBugTrack.DBO.Bug>();
            try
            {
                DataAccess.Bug dataAccess = new SyndicationServiceBugTrack.DataAccess.Bug();

                List<DataAccess.T_Bug> tmpList = dataAccess.GetLastBug(max);
                //crée la liste d'objet que nous afficherons aprés dans le flux
                foreach (DataAccess.T_Bug item in tmpList)
                {
                    DBO.Bug bug = new SyndicationServiceBugTrack.DBO.Bug()
                    {
                        CreateDate = item.CreateDate,
                        Details = item.Description,
                        ProjectName = item.T_Project.name,
                        Title = item.title
                    };
                    list.Add(bug);
                }
                return list;
            }
            catch (Exception ex)
            {
                return list;
            }
        }
    }
}
