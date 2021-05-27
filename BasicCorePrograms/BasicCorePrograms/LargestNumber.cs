using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LargestNumber
    {
        public void Largest(double num1, double num2, double num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is largest");
            }
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is largest");
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3 + " is largest");
            }
            if (num1.Equals(num2) && num1.Equals(num3))
            {
                Console.WriteLine(num1 + " " + num2 + " " + num3 + " are equal");
            }
        }
    }
}
