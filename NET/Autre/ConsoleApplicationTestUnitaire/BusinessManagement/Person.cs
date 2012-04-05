using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationTestUnitaire.BusinessManagement
{
   public class Person
    {
       public static bool SavePerson(DBO.Person pers)
       {
           return DataAccess.Person.SavePerson(pers);
       }

       public static DBO.Person GetPerson(int id)
       {
           return DataAccess.Person.GetPerson(id);
       }
    }
}
