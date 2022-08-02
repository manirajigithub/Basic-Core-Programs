using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorNumber
{
    public static class UC5_FactorNumber
    {
        public static void CheckUC5_FactorNumber()
        {
            Console.WriteLine("Write a Number");
            int P = Convert.ToInt32(Console.ReadLine());
            int N;

            for (N = 1; (N * N <= P); N++)
            {
                if ((P % N == 0))

                    Console.WriteLine(N + "is PrimeFactor ");

            }
        }
    }
}
