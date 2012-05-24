using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.DataAccess
{
    public class Transaction
    {
        public bool CreateTransaction(T_Transaction transaction, long idBug, long idUser)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                transaction.T_Bug.id = idBug;
                transaction.T_User.id = idUser;
                bugtrack.AddToT_Transaction(transaction);
                bugtrack.SaveChanges();

                var test = from b in bugtrack.T_Transaction
                           where b.id == transaction.id
                           select b;

                return (test.Count() > 0);
            }
        }

        public bool DeleteTransaction(long id)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                bugtrack.DeleteObject(bugtrack.T_Transaction.Where(t => t.id == id).FirstOrDefault());
                bugtrack.SaveChanges();

                var test = from b in bugtrack.T_Transaction
                           where b.id == id
                           select b;

                return (test.Count() == 0);
            }
        }

        public bool UpdateTransaction(T_Transaction transaction)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                T_Transaction trans = bugtrack.T_Transaction.Where(t => t.id == transaction.id).FirstOrDefault();

                if (trans != null)
                {
                    trans = transaction;
                    bugtrack.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public T_Transaction GetTransaction(long id)
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                T_Transaction trans = bugtrack.T_Transaction.Where(t => t.id == id).FirstOrDefault();

                if (trans != null)
                {
                    return (trans);
                }

                return null;
            }
        }

        public List<T_Transaction> GetListTransaction()
        {
            using (BugTrackLikeEntities bugtrack = new BugTrackLikeEntities())
            {
                List<T_Transaction> list = bugtrack.T_Transaction.ToList();
                return (list);
            }
        }
    }
}