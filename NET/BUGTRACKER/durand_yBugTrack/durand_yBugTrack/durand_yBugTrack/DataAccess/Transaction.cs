using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.DataAccess
{
    public class Transaction
    {
        public bool CreateTransaction(T_Transaction Transaction, long idProject)
        {
            return false;
        }

        public bool DeleteTransaction(long id)
        {
            return false;
        }

        public bool UpdateTransaction(T_Transaction Transaction)
        {
            return false;
        }

        public T_Transaction GetTransaction(long id)
        {
            return;
        }

        public List<T_Transaction> GetListTransaction()
        {
            return;
        }
    }
}