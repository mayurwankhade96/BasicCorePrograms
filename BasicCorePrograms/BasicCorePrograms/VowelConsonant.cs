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

            alphabet = char.ToLower(alphabet);
            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine(alphabet + " is a vowel");
                    break;

                case 'e':
                    Console.WriteLine(alphabet + " is a vowel");
                    break;

                case 'i':
                    Console.WriteLine(alphabet + " is a vowel");
                    break;

                case 'o':
                    Console.WriteLine(alphabet + " is a vowel");
                    break;

                case 'u':
                    Console.WriteLine(alphabet + " is a vowel");
                    break;

                default:
                    Console.WriteLine(alphabet + " is a consonant");
                    break;
            }
        }
    }
}
