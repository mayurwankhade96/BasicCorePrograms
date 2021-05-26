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
                Console.WriteLine(num1 + " is largest");
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine(num2 + " is largest");
            else
                Console.WriteLine(num3 + " is largest");
        }
    }
}
