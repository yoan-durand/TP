using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace durand_yBugTrack.Models
{
    public class UserModel
    {
        public List<UserItem> userlist { get; set; }
    }

    public class UserItem
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}