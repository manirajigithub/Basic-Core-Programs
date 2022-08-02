using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;
namespace HornomicNumber
{
    public static class UC4_HornomicNumber
    {
        public static void CheckUC4_HornomicNumber()
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