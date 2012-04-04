using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationTestUnitaire.DataAccess
{
   public class Person
    {
       public static bool SavePerson(DBO.Person person)
       {
           try
           {
             
               if (true)
               {
                   throw new Exception("Exception aleatoire ;)");
               }
               return true;
           }
           catch (Exception ex)
           {
               ex = ex;
               LogMe.Log(ex);
               return false;
           }
       }

       public static DBO.Person GetPerson(int id)
       {
           try
           {
               DBO.Person per = new ConsoleApplicationTestUnitaire.DBO.Person() { Address = "Paris 75013", Firstname = "plop", Function = "qqch", Name = "titi" };
               return per;

           }
           catch (Exception ex)
           {
               LogMe.Log(ex);
               return null;
           }
       }
    }
}
