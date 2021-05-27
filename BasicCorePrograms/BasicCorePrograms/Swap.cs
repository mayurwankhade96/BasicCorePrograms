using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Swap
    {
        public void SwapTwoNumbers(int numberOne, int numberTwo)
        {            
            numberOne = numberOne + numberTwo;
            numberTwo = numberOne - numberTwo;
            numberOne = numberOne - numberTwo;

            Console.WriteLine("After Swaping : number one is " + numberOne + " and number two is " + numberTwo);
        }
    }
}
