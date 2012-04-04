using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleFirstProgram
{
    class Program
    {
        private static int Facto(int nb)
        {
            int res = 1;
            if (nb < 0)
                return -1;
            for (int i = 1; i <= nb; i++)
            {
                res *= i;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int res = Facto(5);

            Console.Write(res);
            Console.Read();
        }
    }
}
