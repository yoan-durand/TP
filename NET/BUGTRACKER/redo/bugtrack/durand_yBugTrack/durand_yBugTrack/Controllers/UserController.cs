using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace durand_yBugTrack.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult User()
        {
            durand_yBugTrack.Models.UserModel usermodel = new Models.UserModel();

            usermodel.userlist = BusinessManagement.User.getlist();

            return View("UserView", usermodel);
        }

    }
}
