﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class QuotientRemainder
    {
        public void QuotientAndRemainder()
        {
            Console.WriteLine("Enter a Dividend : ");
            int divident = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = divident / divisor;
            int remainder = divident % divisor;

            Console.WriteLine(quotient + " is quotient, " + remainder + " is remainder");
        }
    }
}
