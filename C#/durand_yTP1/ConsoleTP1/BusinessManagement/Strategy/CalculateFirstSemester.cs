﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.BusinessManagement.Strategy
{
    public class CalculateFirstSemester : ICalculateStrategy
    {

         decimal ICalculateStrategy.CalculateAverage(DBO.Atelier atelier)
        {
            decimal restrack = 0;
            decimal resviva = 0;
            decimal result = 0;

            foreach (decimal elt in atelier.TrackMark)
            {
                restrack += elt * 1;
            }
        

            foreach (decimal elt in atelier.VivaMark)
            {
                resviva += elt * 2;
            }
          

            result = (restrack + resviva) / (atelier.TrackMark.Length + atelier.VivaMark.Length);
            return result;
        }

       
    }
}
