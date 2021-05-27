using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PrimeFactors
    {
        public void Factors()
        {
            Console.WriteLine("Enter a number to find prime factors : ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i=2; i*i<=N; i++)
            {
                while(N % i == 0)
                {
                    Console.WriteLine(i);
                    N = N / i;
                }                
            }
        }
    }
}
