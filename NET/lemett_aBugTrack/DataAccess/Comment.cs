using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lemett_aBugTrack.DataAccess
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
            try
            {

                BugTrackEntities model = new BugTrackEntities();
                comment.T_User = model.T_User.Where(x => x.id == idUser).FirstOrDefault();
                comment.T_Bug = model.T_Bug.Where(x => x.id == idBug).FirstOrDefault();
                model.AddToT_Comment(comment);
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// permet de supprimer un commentaire
        /// </summary>
        /// <param name="id">id du commentaire</param>
        /// <returns>true si bien supprimer sinon false</returns>
        public static bool DeleteComment(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                model.DeleteObject(model.T_Comment.Where(x => x.id == id).FirstOrDefault());
                model.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// permet de mettre  à jour le commentaire
        /// </summary>
        /// <param name="comment">le commentaire a mettre a jour</param>
        /// <returns>true si ca c'est binen passé sinon false</returns>
        public static bool UpdateComment(T_Comment comment)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                T_Comment commentDB = model.T_Comment.Where(x => x.id == comment.id).FirstOrDefault();
                if (commentDB != null)
                {
                    commentDB.details = comment.details;

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
        /// permet de récupérer un commentaire
        /// </summary>
        /// <param name="id">id du commentaire</param>
        /// <returns>le commentaire si tout c'est bien passé sinon null</returns>
        public static T_Comment GetComment(long id)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_Comment.Where(x => x.id == id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// retourne la liste complete de tous les comments
        /// </summary>
        /// <returns>la liste des comments sinon une liste vide</returns>
        public static List<T_Comment> GetListComment()
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_Comment.ToList();
            }
            catch (Exception ex)
            {
                return new List<T_Comment>();
            }
        }



         /// <summary>
        /// retourne la liste complete de tous les comments
        /// </summary>
        /// <param name="idBug">l'id du bug retaché aux commentaires.</param>
        /// <returns>la liste des comments sinon une liste vide</returns>
        public static List<T_Comment> GetListCommentByIdBug(long idBug)
        {
            try
            {
                BugTrackEntities model = new BugTrackEntities();
                return model.T_Comment.Include("T_Bug").Where(x => x.T_Bug.id == idBug).ToList();
            }
            catch (Exception ex)
            {
                return new List<T_Comment>();
            }
        }
    }
}
