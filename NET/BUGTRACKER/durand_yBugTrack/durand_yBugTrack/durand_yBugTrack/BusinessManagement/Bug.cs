using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.BusinessManagement
{
    public class Bug
    {
        public bool CreateBug(DataAccess.T_Bug bug, long idProject)
        {
            DataAccess.Bug b = new DataAccess.Bug();
           return (b.CreateBug (bug, idProject));
        }

        public bool DeleteBug(long id)
        {
            DataAccess.Bug b = new DataAccess.Bug();
           return (b.DeleteBug (id));
        }

        public bool UpdateBug(DataAccess.T_Bug bug)
        {
            DataAccess.Bug b = new DataAccess.Bug();
           return (b.UpdateBug (bug));
            
        }

        public DataAccess.T_Bug GetBug(long id)
        {
            DataAccess.Bug b = new DataAccess.Bug();
           return (b.GetBug(id));
        }

        public List<DataAccess.T_Bug> GetListBug()
        {
           DataAccess.Bug b = new DataAccess.Bug();
           return (b.GetListBug());
        }
    }
    
}