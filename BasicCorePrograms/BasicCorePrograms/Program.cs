﻿using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core programs");

            const int coinFlip = 1;
            const int leapYear = 2;
            const int power = 3;
            const int factors = 5;
            const int quotientRemainder = 6;
            const int swapNumber = 7;
            const int evenOdd = 8;
            const int vowelConsonant = 9;
            const int largestNumber = 10;

            Console.WriteLine("Enter a class number : ");
            int className = Convert.ToInt32(Console.ReadLine());

            switch (className)
            {
                case coinFlip:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.HeadsTailsPercentage();
                    break;

                case leapYear:
                    LeapYear leap = new LeapYear();
                    leap.LeapYr();
                    break;

                case power:
                    Power power1 = new Power();
                    power1.PowerOfTwo();
                    break;

                case factors:
                    PrimeFactors factors1 = new PrimeFactors();
                    factors1.Factors();
                    break;

                case quotientRemainder:
                    QuotientRemainder quotientRemainder1 = new QuotientRemainder();
                    quotientRemainder1.QuotientAndRemainder();
                    break;

                case swapNumber:
                    Swap swap = new Swap();
                    swap.SwapTwoNumbers(5, 15);
                    break;

                case evenOdd:
                    EvenOdd evenOdd1 = new EvenOdd();
                    evenOdd1.EvenOrOdd();
                    break;

                case vowelConsonant:
                    VowelConsonant vowelConsonant1 = new VowelConsonant();
                    vowelConsonant1.VowelOrConsonant();
                    break;

                case largestNumber :
                    LargestNumber num = new LargestNumber();
                    num.Largest(550, 426, 611);
                    break;
            }                           
        }
    }
}
