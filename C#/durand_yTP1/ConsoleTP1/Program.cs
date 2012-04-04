using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1
{
    class Program
    {
        private static IList<DBO.Atelier> InitLIst()
        {
            IList<DBO.Atelier> list = new List<DBO.Atelier> ();

            list.Add(new DBO.Atelier{Name="adobe", Description="organisation evenement adobe", TrackMark=new decimal[] {5, 6, 7, 8}, VivaMark= new decimal[]{10, 15, 18, 4}});
            list.Add(new DBO.Atelier{Name="microsoft", Description="Developpement microsoft", TrackMark=new decimal[] {10,15,12,10}, VivaMark=new decimal[]{10, 5, 8, 4}});
            list.Add(new DBO.Atelier{Name="opensource", Description="mobile android", TrackMark= new decimal [] {1, 16, 7, 18}, VivaMark= new decimal[]{10, 5, 18, 14}});
            list.Add(new DBO.Atelier{Name="adminsys", Description="Administration server", TrackMark=new decimal [] {15, 16, 17, 18}, VivaMark= new decimal[]{1, 8, 18, 14}});
            list.Add(new DBO.Atelier{Name="IOS", Description="Developpement App Iphone", TrackMark= new decimal [] {15, 16, 7, 8}, VivaMark= new decimal [] {10, 8, 8, 15}});
            list.Add(new DBO.Atelier{Name="HTML5/JS", Description="application web javascript", TrackMark= new decimal [] {15, 16, 17, 18}, VivaMark= new decimal [] {10, 15, 18, 14}});

            return list;

        }
        static void Main(string[] args)
        {
            
            IList<DBO.Atelier> list = InitLIst();
            int cpt = 0;
            foreach (DBO.Atelier elt in list)
            {
                cpt++;
                BusinessManagement.Manage.IAtelier atelier = BusinessManagement.FactoryAtelier.getAtelier (elt.Name);
                Console.WriteLine(elt.Name + " " + elt.Description + " " + elt.ToString());
                Console.WriteLine(atelier.Presentation(elt));
                Console.WriteLine(atelier.Calculate(elt));

                
               
            }
            Console.Read();
        }
    }
}
