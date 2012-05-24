using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace durand_yBugTrack.BusinessManagement
{
    public class Comment
    {
        public bool CreateComment(DataAccess.T_Comment comment, long idUser, long idBug)
        {
            DataAccess.Comment com = new DataAccess.Comment();

            return com.CreateComment(comment, idUser, idBug);
        }

        public bool DeleteComment(long id)
        {
            DataAccess.Comment com = new DataAccess.Comment();

            return com.DeleteComment(id);

        }

        public bool UpdateComment(DataAccess.T_Comment comment)
        {
            DataAccess.Comment com = new DataAccess.Comment();

            return com.UpdateComment(comment);
        }

        public DataAccess.T_Comment GetComment(long id)
        {
            DataAccess.Comment com = new DataAccess.Comment();

            return com.GetComment(id);
        }

        public List<DataAccess.T_Comment> GetListComment()
        {
            DataAccess.Comment com = new DataAccess.Comment();
            return com.GetListComment();
        }

        public List<DataAccess.T_Comment> GetListCommentbyIdBug(long idBug)
        {
            DataAccess.Comment com = new DataAccess.Comment();

            return com.GetListCommentbyIdBug(idBug);
        }
    }
}