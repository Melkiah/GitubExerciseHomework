using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static bool isPrime(long n)
        {
            if(n == 1 || n == 0)
            {
                return false;
            }
            else if(n == 2)
            {
                return true;
            }

            for(int i = 2; i<=Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool resultPrime = isPrime(n);
            Console.WriteLine(resultPrime);
            String stopTheConsole = Console.ReadLine();
        }
    }
}
