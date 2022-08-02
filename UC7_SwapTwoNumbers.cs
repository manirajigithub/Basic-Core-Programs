using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    public static class UC7_SwapTwoNumbers
    {
        public static void CheckUC7_SwapTwoNumbers()
        {
            int firstNum = 100;
            int secNum = 50;

            firstNum *= secNum;
            secNum = firstNum / secNum;
            firstNum /= secNum;

            Console.WriteLine("SwapValue of firstNum :" + firstNum);
            Console.WriteLine("SwapValue of secNum:" + secNum);
        }
    }
}

