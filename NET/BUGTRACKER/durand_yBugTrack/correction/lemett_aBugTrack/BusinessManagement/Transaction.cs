using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lemett_aBugTrack.DataAccess;

namespace lemett_aBugTrack.BusinessManagement
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
            return DataAccess.Transaction.CreateTransaction(Transaction, idBug, idUser);
        }

        /// <summary>
        /// permet de supprimer une transaction
        /// </summary>
        /// <param name="id">id de la transaction</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteTransaction(long id)
        {
            return DataAccess.Transaction.DeleteTransaction(id);
        }

        /// <summary>
        /// permet de mettre  à jour la transaction
        /// </summary>
        /// <param name="Transaction">la transaction a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateTransaction(T_Transaction Transaction)
        {
            return DataAccess.Transaction.UpdateTransaction(Transaction);
        }

        /// <summary>
        /// permet de récupérer une transaction
        /// </summary>
        /// <param name="id">id de la transaction</param>
        /// <returns>le Transaction si tout c'est bien passé sinon null</returns>
        public static T_Transaction GetTransaction(long id)
        {
            return DataAccess.Transaction.GetTransaction(id);

        }

        /// <summary>
        /// permet de récupérer une transaction
        /// </summary>
        /// <param name="id">id de la transaction</param>
        /// <returns>le Transaction si tout c'est bien passé sinon null</returns>
        public static T_Transaction GetTransactionWithDetach(long id)
        {
            return DataAccess.Transaction.GetTransaction(id);

        }

        /// <summary>
        /// retourne la liste complete de tous les Transactions
        /// </summary>
        /// <returns>la liste des Transactions sinon une liste vide</returns>
        public static List<T_Transaction> GetListTransaction()
        {
            return DataAccess.Transaction.GetListTransaction();
        }
    }
}
