using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.BusinessManagement
{
    public class FactoryAtelier
    {
        public static Manage.IAtelier getAtelier(string typeName)
        {
            switch (typeName)
            {
                case "adobe":
                    return (new Manage.Adobe ());
                case "Adobe":
                    return (new Manage.Adobe ());
                case "ADOBE":
                    return (new Manage.Adobe());
                case "microsoft":
                    return (new Manage.Microsoft ());
                case "Microsoft":
                    return (new Manage.Microsoft ());
                case "MICROSOFT":
                    return (new Manage.Microsoft());
                case "opensource":
                    return (new Manage.OtherTechno());
                case "OpenSource":
                    return (new Manage.OtherTechno());
                case "OPENSOURCE":
                    return (new Manage.OtherTechno());
                case "adminsys":
                    return (new Manage.OtherTechno());
                case "AdminSys":
                    return (new Manage.OtherTechno());
                case "ADMINSYS":
                    return (new Manage.OtherTechno());
                default :
                    return (new Manage.DefaultAtelier ());
            }
        }
    }
}
