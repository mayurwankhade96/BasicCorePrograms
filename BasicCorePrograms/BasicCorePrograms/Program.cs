using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to basic core programs");
            Console.WriteLine("Enter a Program number : ");
            Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("2. Leap Year");
            Console.WriteLine("3. Power of 2");
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Factors");
            Console.WriteLine("6. Compute Quotient and Remainder");
            Console.WriteLine("7. Swap Two Numbers");
            Console.WriteLine("8. Check Whether a Number is Even or Odd");
            Console.WriteLine("9. Check Whether an Alphabet is Vowel or Consonant");
            Console.WriteLine("10.Find the Largest Among Three Numbers");

            int programNumber = Convert.ToInt32(Console.ReadLine());

            switch (programNumber)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.HeadsTailsPercentage();
                    break;

                case 2:
                    LeapYear leap = new LeapYear();
                    leap.LeapYr();
                    break;

                case 3:
                    Power power1 = new Power();
                    power1.PowerOfTwo();
                    break;

                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.HarmonicNumberSum();
                    break;

                case 5:
                    PrimeFactors factors1 = new PrimeFactors();
                    factors1.Factors();
                    break;

                case 6:
                    QuotientRemainder quotientRemainder1 = new QuotientRemainder();
                    quotientRemainder1.QuotientAndRemainder();
                    break;

                case 7:
                    Swap swap = new Swap();
                    swap.SwapTwoNumbers(5, 15);
                    break;

                case 8:
                    EvenOdd evenOdd1 = new EvenOdd();
                    evenOdd1.EvenOrOdd();
                    break;

                case 9:
                    VowelConsonant vowelConsonant1 = new VowelConsonant();
                    vowelConsonant1.VowelOrConsonant();
                    break;

                case 10:
                    LargestNumber num = new LargestNumber();
                    num.Largest(550, 426, 611);
                    break;

                default:
                    Console.WriteLine("Invalid input, Please select again from given options : ");
                    Program.Main();
                    break;
            }                           
        }
    }
}
