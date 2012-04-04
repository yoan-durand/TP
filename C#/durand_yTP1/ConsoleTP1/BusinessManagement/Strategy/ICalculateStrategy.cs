using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.BusinessManagement.Strategy
{
    public interface ICalculateStrategy
    {
         decimal CalculateAverage(DBO.Atelier atelier);
    }
}
