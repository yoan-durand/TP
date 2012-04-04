using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSecondProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataAccess.ReadFile read = new DataAccess.ReadFile("WLMContacts.csv");

            List<DBO.Person> list = BusinessManagement.Person.ReadData("test.csv");

            foreach (DBO.Person person in list)
            {
                Console.Write(person.Name+";"+person.FirstName+";"+person.Adress+"\n");
            }
            Console.Read();
        }
    }
}
