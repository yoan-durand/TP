using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lemett_aBugTrack.DataAccess;

namespace lemett_aBugTrack.BusinessManagement
{
    public class Comment
    {
        /// <summary>
        /// permet la création d'un comment
        /// </summary>
        /// <param name="comment">l'objet commentaire à crer</param>
        /// <returns>true si tout se passe bien sinon false</returns>
        public static bool CreateComment(T_Comment comment, long idUser, long idBug)
        {
            return DataAccess.Comment.CreateComment(comment, idUser, idBug);
        }

        /// <summary>
        /// permet de supprimer un commentaire
        /// </summary>
        /// <param name="id">id du commentaire</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteComment(long id)
        {
            return DataAccess.Comment.DeleteComment(id);
        }

        /// <summary>
        /// permet de mettre  à jour le commentaire
        /// </summary>
        /// <param name="comment">le commentaire a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateComment(T_Comment comment)
        {
            return DataAccess.Comment.UpdateComment(comment);
        }

        /// <summary>
        /// permet de récupérer un commentaire
        /// </summary>
        /// <param name="id">id du commentaire</param>
        /// <returns>l'comment si tout c'est bien passé sinon null</returns>
        public static T_Comment GetComment(long id)
        {
            return DataAccess.Comment.GetComment(id);

        }

        /// <summary>
        /// retourne la liste complete de tous les comments
        /// </summary>
        /// <param name="idBug">l'id du bug retaché aux commentaires.</param>
        /// <returns>la liste des comments sinon une liste vide</returns>
        public static List<T_Comment> GetListCommentByIdBug(long idBug)
        {
            return DataAccess.Comment.GetListCommentByIdBug(idBug);
        }

        /// <summary>
        /// retourne la liste complete de tous les comments
        /// </summary>
        /// <returns>la liste des comments sinon une liste vide</returns>
        public static List<T_Comment> GetListComment()
        {
            return DataAccess.Comment.GetListComment();
        }
    }
}
