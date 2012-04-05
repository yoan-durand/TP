using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.BusinessManagement.Manage
{
    public class OtherTechno : DefaultAtelier
    {
        public override string Presentation(DBO.Atelier atelier)
        {
            DefaultAtelier ate = new DefaultAtelier();
            string str = ate.Presentation(atelier);
            str += "\nUrl :" + "http://mti.epita.fr";
            return (str);
        }
    }
}
