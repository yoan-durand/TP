using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.BusinessManagement.Manage
{
    public class Microsoft : DefaultAtelier
    {
        public override string Presentation(DBO.Atelier atelier)
        {
            DefaultAtelier ate = new DefaultAtelier();
            string str = ate.Presentation(atelier);
            str += "\nUrl :" + "http://microsoft.com";
            return (str);
        }
    }
}
