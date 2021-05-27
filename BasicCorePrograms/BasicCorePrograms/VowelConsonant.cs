using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class VowelConsonant
    {
        public void VowelOrConsonant()
        {
            Console.WriteLine("Enter a alphabet to check whether it is a vowel or consonant : ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            if (alphabet == 'a' || alphabet == 'A' ||
                alphabet == 'e' || alphabet == 'E' ||
                alphabet == 'i' || alphabet == 'I' ||
                alphabet == 'o' || alphabet == 'O' ||
                alphabet == 'u' || alphabet == 'U')
                Console.WriteLine(alphabet + " is a vowel");
            else
                Console.WriteLine(alphabet + " is a consonant");
        }
    }
}
