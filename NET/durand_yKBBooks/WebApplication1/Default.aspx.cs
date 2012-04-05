using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DBO.Books> list = new List<DBO.Books>();
            List<DBO.Books> list_bis = new List<DBO.Books>();
            list_bis = BuisinessManagement.Echange.parse("test_xml.xml", 0);
            BuisinessManagement.Echange.create(list, 0);
            list = BuisinessManagement.Echange.parse("test_xml.xml",1);
            BuisinessManagement.Echange.create(list, 1);
        }
    }
}
