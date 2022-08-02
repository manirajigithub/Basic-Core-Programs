using System;
using System.Collections.Generic;
using System.Text;
namespace PowerOf2

{
    public static class UC3_PowerOf2
    {
        public static void CheckUC3_PowerOf2()
        {
            int n = 0;

              while( n<31)
            {
                  double power = Math.Pow(2, n);
                  Console.WriteLine(power);
                  n++;
              }
        }
    }
}

        

