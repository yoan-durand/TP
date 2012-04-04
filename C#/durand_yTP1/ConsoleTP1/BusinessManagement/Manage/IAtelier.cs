using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.BusinessManagement.Manage
{
   public interface IAtelier
    {
         decimal Calculate(DBO.Atelier atelier);

         String Presentation(DBO.Atelier atelier);
    }
}
