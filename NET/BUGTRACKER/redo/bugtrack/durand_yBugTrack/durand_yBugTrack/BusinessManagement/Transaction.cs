using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.BusinessManagement
{
    public class Transaction
    {
        public bool CreateTransaction(DataAccess.T_Transaction transaction, long idBug, long idUser)
        {
            DataAccess.Transaction trans = new DataAccess.Transaction();

            return trans.CreateTransaction(transaction, idBug, idUser);
        }

        public bool DeleteTransaction(long id)
        {
            DataAccess.Transaction trans = new DataAccess.Transaction();

            return trans.DeleteTransaction(id);
        }

        public bool UpdateTransaction(DataAccess.T_Transaction transaction)
        {
            DataAccess.Transaction trans = new DataAccess.Transaction();

            return trans.UpdateTransaction(transaction);
        }

        public DataAccess.T_Transaction GetTransaction(long id)
        {
            DataAccess.Transaction trans = new DataAccess.Transaction();

            return trans.GetTransaction(id);
        }

        public List<DataAccess.T_Transaction> GetListTransaction()
        {
            DataAccess.Transaction trans = new DataAccess.Transaction();

            return trans.GetListTransaction();
        } 
    }
}