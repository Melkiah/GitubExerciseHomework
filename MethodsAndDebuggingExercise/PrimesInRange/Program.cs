using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInRange
{
    class PrimesInRange
    {
        static bool isPrime(long n)
        {
            if (n == 1 || n == 0)
            {
                return false;
            }
            else if (n == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static List<int> AllPrimesInRange(int start, int end)
        {
            List<int> allPrimes = new List<int>();

            for(int i = start; i <= end; i++)
            {
                if (isPrime(i))
                {
                    allPrimes.Add(i);
                }
            }

            return allPrimes;
        }

        static void Main(string[] args)
        {
            int beginRange = int.Parse(Console.ReadLine());
            int endRange = int.Parse(Console.ReadLine());

            List<int> result = AllPrimesInRange(beginRange, endRange);

            foreach (int primeNumber in result)
            {
                if (primeNumber == result.Last())
                {
                    Console.Write(primeNumber);
                    break;
                }
                Console.Write(primeNumber + ", ");                
            }
            String stopTheConsole = Console.ReadLine();
        }
    }
}
