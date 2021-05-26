using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core programs");

            Console.WriteLine("Enter a method number : ");
            int methodNumber = Convert.ToInt32(Console.ReadLine());

            switch (methodNumber)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.HeadsTailsPercentage();
                    break;

                case 2:
                    LeapYear leap = new LeapYear();
                    leap.LeapYr();
                    break;
            }                           
        }
    }
}
