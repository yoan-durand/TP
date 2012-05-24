using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lemett_aBugTrack.DataAccess
{
    public class Transaction
    {
        /// <summary>
        /// permet la création d'une transaction
        /// </summary>
        /// <param name="Transaction">l'objet Transaction à crer</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool CreateTransaction(T_Transaction Transaction, long idBug, long idUser)
        {
            try
            {

                BugTrackEntities model = new BugTrackEntities();
                Transaction.T_User = model.T_User.Where(x => x.id == idUser).FirstOrDefault();
                Transaction.T_Bug = model.T_Bug.Where(x => x.id == idBug).FirstOrDefault();
                model.AddToT_Transaction(Transaction);
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// permet de supprimer une transaction
        /// </summary>
        /// <param name="id">id de la transaction</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteTransaction(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                model.DeleteObject(model.T_Transaction.Where(x => x.id == id).FirstOrDefault());
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// permet de mettre  à jour la transaction
        /// </summary>
        /// <param name="Transaction">la transaction a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateTransaction(T_Transaction Transaction)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                T_Transaction TransactionDB = model.T_Transaction.Where(x => x.id == Transaction.id).FirstOrDefault();
                if (TransactionDB != null)
                {
                    TransactionDB.statut = Transaction.statut;

                    model.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// permet de récupérer une transaction
        /// </summary>
        /// <param name="id">id de la transaction</param>
        /// <returns>le Transaction si tout c'est bien passé sinon null</returns>
        public static T_Transaction GetTransaction(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_Transaction.Where(x => x.id == id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// retourne la liste complete de tous les Transactions
        /// </summary>
        /// <returns>la liste des Transactions sinon une liste vide</returns>
        public static List<T_Transaction> GetListTransaction()
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_Transaction.ToList();
            }
            catch (Exception ex)
            {
                return new List<T_Transaction>();
            }
        }
    }
}
