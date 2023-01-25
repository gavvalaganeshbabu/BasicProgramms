using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice Between This :");
            Console.WriteLine("1. For Finding Even Odd :");
            Console.WriteLine("2. For Swapping Two Numbers :");
            Console.WriteLine("3. For Checking Vowel or Consonent :");
            Console.WriteLine("4. For Finding Harmonic Series :");
            Console.WriteLine("5. For Finding Quotient and Reminder :");
            Console.WriteLine("6. For Finding Biggest Among Three :");
            Console.WriteLine("7. For Finding Fibbonocci Series :");
            Console.WriteLine("8. For Checking ArmStron Number or Not :");
            Console.WriteLine("9. For Checking Number is Plaindrome Or Not :");            
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    EvenOdd e = new EvenOdd();
                    e.EvenOd();
                    break;
                case 2:
                    SwappingTwo s = new SwappingTwo();
                    s.SwapTwo();
                    break;
                case 3:
                    VowelsOrConsonents v = new VowelsOrConsonents();
                    v.FindVowelConsonent();
                    break;
                case 4:
                    Harmonic h = new Harmonic();
                    h.HarmonicFind();
                    break;
                case 5:
                    QuotientReminder q = new QuotientReminder();
                    q.QuotientFinder();
                    break;
                case 6:
                    BiggestAmong3 b = new BiggestAmong3();
                    b.BiggestOfThree();
                    break;
                case 7:
                    Fibbonocci f = new Fibbonocci();
                    f.FibbonicciSeries();
                    break;
                case 8:
                    ArmStrong a = new ArmStrong();
                    a.ArmStrongFinder();
                    break;
                case 9:
                    PalindromeNumber p = new PalindromeNumber();
                    p.PalindromeNum();
                    break;
                default:
                    Console.WriteLine("Invalid Option :");
                    break;


            }
        }
    }
}
