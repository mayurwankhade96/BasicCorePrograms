using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Power
    {
        public void PowerOfTwo()
        {
            Console.WriteLine("Enter a value of N : ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<=N; i++)
            {
                long result = Convert.ToInt64(Math.Pow(2, i));
                Console.WriteLine(result);
            }
        }
    }
}
