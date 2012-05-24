using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.DataAccess
{
    public class Comment
    {
        public bool CreateComment(T_Comment comment, long idUser, long idBug)
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                comment.T_User.id = idUser;
                comment.T_Bug.id = idBug;

                bugtrack.AddToT_Comment(comment);
                bugtrack.SaveChanges();
                return true;
            }
        }

        public bool DeleteComment(long id)
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                bugtrack.DeleteObject(bugtrack.T_Comment.Where(c => c.id == id).FirstOrDefault());
                bugtrack.SaveChanges();
                return true;
            }

        }

        public bool UpdateComment(T_Comment comment)
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                T_Comment com = bugtrack.T_Comment.Where(c => c.id == comment.id).FirstOrDefault();

                if (com != null)
                {
                    com = comment;
                }
                bugtrack.SaveChanges();
                return true;
            }
        }

        public T_Comment GetComment(long id)
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                T_Comment com = bugtrack.T_Comment.Where(c => c.id == id).FirstOrDefault();

                if (com != null)
                {
                    return (com);
                }

                return null;
            }
        }

        public List<T_Comment> GetListComment()
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                List<T_Comment> list = bugtrack.T_Comment.ToList();
                return (list);
            }
        }

        public List<T_Comment> GetListCommentbyIdBug(long idBug)
        {
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                List<T_Comment> com_List = bugtrack.T_Comment.Where(c => c.T_Bug.id == idBug).ToList();

                return (com_List);
            }
        }

        public List<string> getListCommentbyIdbug(long idBug)
        {
            List<string> res = new List<string>();
            using (BugTrackEntities2 bugtrack = new BugTrackEntities2())
            {
                List<T_Comment> com_List = bugtrack.T_Comment.Where(c => c.T_Bug.id == idBug).ToList();


                foreach (T_Comment item in com_List)
                {
                    res.Add(item.details);
                }

                return (res);
            }
        }
    }
}