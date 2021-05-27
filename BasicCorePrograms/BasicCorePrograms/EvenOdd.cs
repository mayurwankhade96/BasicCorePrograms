using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Eneter a number to check even or odd : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine(number + " is even");
            else
                Console.WriteLine(number + " is odd");
        }
    }
}
