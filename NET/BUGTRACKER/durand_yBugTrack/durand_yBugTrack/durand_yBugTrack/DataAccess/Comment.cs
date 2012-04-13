using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.DataAccess
{
    public class Comment
    {
        public bool CreateComment(T_Comment Comment, long idProject)
        {
            return false;
        }

        public bool DeleteComment(long id)
        {
            return false;
        }

        public bool UpdateComment(T_Comment Comment)
        {
            return false;
        }

        public T_Comment GetComment(long id)
        {
            return;
        }

        public List<T_Comment> GetListComment()
        {
            return;
        }

        public List<T_Comment> GetListCommentbyIdBug(long idBug)
        {
            return;
        }
    }
}