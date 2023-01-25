using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class VowelsOrConsonents
    {
        public void FindVowelConsonent() {
            Console.WriteLine("Enter small Letters Only :");
            char ch = Console.ReadLine()[0];
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else { Console.WriteLine("Consonents"); }
        }
    }
}
