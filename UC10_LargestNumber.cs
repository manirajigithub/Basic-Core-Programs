using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    public static class UC10_LargestNumber
    {
        public static void CheckUC10_LargestNumber()
        {
            Console.WriteLine("Type Any 3 Numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine("X is greater");
            }
            else if (y > z && y > x)
            {
                Console.WriteLine("Y is greater");
            }
            else
            {
                Console.WriteLine("Z is greater");
            }
        }
    }
}

           

