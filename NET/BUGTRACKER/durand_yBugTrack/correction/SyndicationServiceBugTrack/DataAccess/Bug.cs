using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyndicationServiceBugTrack.DataAccess
{
    public class Bug
    {

        DataAccess.DataClassesBugTrackDataContext _dataContext;

        public Bug()
        {
            _dataContext = new DataClassesBugTrackDataContext();
        }

        public List<T_Bug> GetLastBug(int max)
        {

            try
            {
                //permet d'ordonner les bugs selon date de creation et de prendre seulemenent les max premiers
                return _dataContext.T_Bugs.OrderBy(x => x.CreateDate).Take(max).ToList<T_Bug>();
            }
            catch (Exception ex)
            {
                return new List<T_Bug>();
            }
        }

    }
}
