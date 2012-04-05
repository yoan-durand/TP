using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.Tools
{
    class Tools
    {
        public static void PrintArray<E>(E[] inputArray)
        {
            foreach (E elt in inputArray)
            {
                Console.Write(elt.ToString() + " ");                
            }
            Console.Write('\n');
        }
    }
}
