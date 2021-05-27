using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class HarmonicNumber
    {
        public double sum = 0;
        public void HarmonicNumberSum()
        {            
            Console.WriteLine("Enter a positive integer : ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                sum += (1.0 / i);
            }
            Console.WriteLine(sum);
        }
    }
}
