using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationTestUnitaire
{
    class Program
    {
        static void Main(string[] args)
        {
            DBO.Person per = new ConsoleApplicationTestUnitaire.DBO.Person();

            Console.WriteLine("nom :");
            per.Name = Console.ReadLine();
            Console.WriteLine("prénom :");
            per.Firstname = Console.ReadLine();
            Console.WriteLine("fonction :");
            per.Function = Console.ReadLine() ;
            Console.WriteLine("Adresse :");
            per.Address = Console.ReadLine();

            BusinessManagement.Person.SavePerson(per);

            DBO.Person per2 = BusinessManagement.Person.GetPerson(10);
        }
    }
}
