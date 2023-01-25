using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class ArmStrong
    {
        public  void ArmStrongFinder() {
            Console.WriteLine("Enter The Number :");
            int n=int.Parse(Console.ReadLine());
            bool x = isArmStrong(n);
            Console.WriteLine(x);
        }
        public static bool isArmStrong(int n)
        {
            int count = isCount(n);
            int sum = 0, temp = n;

            do {
                int d = n % 10;
                sum = sum + isPow(d, count);
                n /= 10;
            } while (n > 0);
            return (sum==temp);
        }
        public static int isCount(int n) {
            int c = 0;
            do { 
            c++;
            n /= 10;
            }while(n > 0);
            return c;
        }
        public static int isPow(int n,int p) {
            int pow = 1;
            do {
            pow=pow* n;
                p--;
            } while (p > 0);return pow;
        }
    }
}
