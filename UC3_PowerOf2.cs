using System;
using System.Collections.Generic;
using System.Text;
namespace PowerOf2

{
    public static class UC3_PowerOf2
    {
        public static void CheckUC3_PowerOf2()
        {

           
            int i, n;
            n = 50;
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);

            }
            if (n == 50)
            {
                Console.WriteLine("The nth Harmonic Number : 1/{0} ", n);
            }
        }
    }
}