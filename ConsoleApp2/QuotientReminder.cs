using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class QuotientReminder
    {
        public void QuotientFinder() {
            Console.WriteLine("Enter The two Numbers :");
            int divident = int.Parse(Console.ReadLine());
            int divisor = int.Parse(Console.ReadLine());
            double quotient = divident / divisor;
            double reminder = divident % divisor;
            Console.WriteLine("quotient is :" + quotient);
            Console.WriteLine("divisor is :" + divisor);
        }
    }
}
