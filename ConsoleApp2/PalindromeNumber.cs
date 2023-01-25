using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class PalindromeNumber
    {
        public  void PalindromeNum() {
            Console.WriteLine("Enter The Number :");
            int n = int.Parse(Console.ReadLine());
            bool x = isPalindrome(n);
            Console.WriteLine(x);
        }

        public static bool isPalindrome(int n)
        {
            
            int rev = 0, temp = n;
            do {
                int d = n % 10;
                rev = rev * 10 + d;
                n = n / 10;
            } while (n > 0);
            return (temp==rev);
        }
    }
}
