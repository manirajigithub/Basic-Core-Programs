using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    public static class UC8_EvenOrOdd
    {
        public static void CheckUC8_EvenOrOdd()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = A + B;
            Console.WriteLine(C);
            if (C % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
