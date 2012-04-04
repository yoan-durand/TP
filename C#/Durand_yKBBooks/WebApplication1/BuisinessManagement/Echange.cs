using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.BuisinessManagement
{
    public class Echange
    {
        public static List<DBO.Books> parse(string xmlname, int i)
        {
            DataAccess.Echange parse = new DataAccess.Echange();

            if (i == 0)
            {
                return (parse.parseDom(xmlname));
            }
            else
            {
                return (parse.parse_linq (xmlname));
            }
        }

        public static void create(List<DBO.Books> list, int i)
        {
            DataAccess.Echange echange = new DataAccess.Echange();

            if (i == 0)
            {
                if (list.Count > 0)
                {
                    echange.create_DOM(list);
                }
            }
            else
            {
                if (list.Count > 0)
                {
                    echange.create_linq (list);
                }    
            }
        }
    }
}