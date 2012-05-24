using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lemett_aBugTrack.DataAccess;

namespace lemett_aBugTrack
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess.T_User user = new lemett_aBugTrack.DataAccess.T_User()
            {
                email = "toto@orange.fr",
                firstname = "toto",
                name = "titi",
                password = "t@t@",
                phone = "023565",
            };


            BusinessManagement.User.CreateUser(user);
            user = BusinessManagement.User.GetUser(1);

            user.password = "t0t0";
            BusinessManagement.User.UpdateUser(user);


            T_Project project = new T_Project()
            {
                name = "APM",
                startDate = DateTime.Now,
                version = "0.0.1"
            };
            BusinessManagement.Project.CreateProject(project);
            project = BusinessManagement.Project.GetProject(1);

            project.version = "0.0.2";
            BusinessManagement.Project.UpdateProject(project);

                      
            T_BugCritic bugCritic = new T_BugCritic()
            {
                CreateDate = DateTime.Now,
                Description = "bug critic",
                title = "plantage grave",
                
            };
            
            
            

            BusinessManagement.Bug.CreateBugCritic(bugCritic, project.id);

            T_Bug bug = BusinessManagement.Bug.GetBug(1);

            T_Transaction trans = new T_Transaction()
            {
                statut = (int)DBO.EnumStatut.Accepted,
            };

            BusinessManagement.Transaction.CreateTransaction(trans, bug.id, user.id);
            
            T_Comment comment = new T_Comment()
            {
                details = "voir msdn",
              
                
            };
            BusinessManagement.Comment.CreateComment(comment, user.id, bug.id);
            comment = BusinessManagement.Comment.GetComment(1);

            comment.details = "ou microsoft";
            BusinessManagement.Comment.UpdateComment(comment);

            
            BusinessManagement.GenerateDocx.GenerateReportBug(1);

            BusinessManagement.Comment.DeleteComment(comment.id);
            BusinessManagement.Transaction.DeleteTransaction(trans.id);
            BusinessManagement.Bug.DeleteBug(bug.id);
            BusinessManagement.Project.DeleteProject(project.id);
            BusinessManagement.User.DeleteUser(user.id);
        }
    }
}
