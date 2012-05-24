using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientBugTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;

            Console.WriteLine("Client Bug Track \n\n");
            Console.WriteLine("Nombre maximum de resultat : \n");
            string maxResponse = Console.ReadLine();
            if (Int32.TryParse(maxResponse, out max))
            {
                Console.WriteLine("Liste client avec EF : \n");
                List<ServiceReferenceBugTrack.T_Bug> listRes = BusinessManagement.BugTrack.GetListBugWithEF(max);
                foreach (ServiceReferenceBugTrack.T_Bug item in listRes)
                {
                    Console.WriteLine(item.T_Project.name + " : " +item.title );
                    Console.WriteLine(item.T_Transaction.First().T_User.name + "=>" + item.CreateDate.ToString());
                }


                Console.WriteLine("Liste client avec objetWcf : \n");
                List<ServiceReferenceBugTrack.BugTransfert> listResWCF = BusinessManagement.BugTrack.GetListBug(max);
                foreach (ServiceReferenceBugTrack.BugTransfert item in listResWCF)
                {
                    Console.WriteLine(item.ProjectName + " : " + item.Title);
                    Console.WriteLine(item.Responsable + "=>" + item.CreateDate.ToString());
                }

            }
            else
            {
                Console.WriteLine("Nombre de résultat incorrect\n Fin du programme");
            }
            Console.ReadKey();

        }
    }
}
