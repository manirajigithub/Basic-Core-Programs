using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoin
{

    public static class UC1_FlipCoin
    {
        static int headCount = 0;
        static int tailCount = 0;

        static double percentageHeadCount;
        static double percentageTailCount;

        public static void CheckUC1_flipcoin()
        {
            Console.WriteLine("Please enter Number of times to  Flip the coin:");
            int Flip = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Flip; i++)
            {

                Random random = new Random();
                int num = random.Next(2);
                Console.WriteLine("The random number from the sysytem" + num);
                if (num == 0)
                {
                    Console.WriteLine("Tails ");
                    tailCount++;
                }
                else if (num == 1)
                {
                    Console.WriteLine("Head");
                    headCount++;
                }
            }
            percentageHeadCount = (headCount * 100) / Flip;
            percentageTailCount = (tailCount * 100) / Flip;

            Console.WriteLine("Head percentage  " + percentageHeadCount);
            Console.WriteLine("Tail percentage  " + percentageTailCount);
        }


    }
}
