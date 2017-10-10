using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEritostenes
{
    class SieveOfEratostenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1];

            for (int i = 0; i <= n; i++)
            {
                if(i == 0 || i == 1)
                {
                    continue;
                }
                else
                {
                    primes[i] = true;
                }
            }
            

            for (int i = 0; i <= n; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");

                    for (int j = i*i; j <= n; j = j + i)
                    {
                        primes[j] = false;
                    }
                }
            }
            

        }
    }
}
