using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.BusinessManagement.Manage
{
     public class DefaultAtelier : IAtelier
    {

        public BusinessManagement.Strategy.ICalculateStrategy CalculateStrategy { get; set; }

        public DefaultAtelier()
        {
        }

        public decimal Calculate(DBO.Atelier atelier)
        {
            decimal restrack = 0;
            decimal resviva = 0;
            decimal result = 0;

            if (CalculateStrategy != null)
            {
                return CalculateStrategy.CalculateAverage(atelier);
            }
            else
            {
                foreach (decimal elt in atelier.TrackMark)
                {
                    restrack += elt;
                }
                

                foreach (decimal elt in atelier.VivaMark)
                {
                    resviva += elt;
                }
                

                result = (restrack + resviva) / (atelier.TrackMark.Length + atelier.VivaMark.Length);
            }
            return result;
        }

        public virtual string Presentation(DBO.Atelier atelier)
        {
            string str = "";
            str ="Name : "  + atelier.Name + "\n\n\n"+"Description : "+ atelier.Description;

            return str;
        }
    }
}
