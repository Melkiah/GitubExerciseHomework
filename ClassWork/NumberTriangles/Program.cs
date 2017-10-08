using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTriangles
{
    class Program
    {
        static void PrintConsecutiveNumbers(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                PrintConsecutiveNumbers(i);
            }

            for (int i = size - 1; i >= 1; i--)
            {
                PrintConsecutiveNumbers(i);
            }

            Console.ReadLine();
        }
    }
}
