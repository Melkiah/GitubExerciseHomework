using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    class Program
    {
        static void PrintMultipleSymbols(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        static void PrintSquareBody(int size)
        {
            Console.Write('-');
            for(int i = 1; i <= size-1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintMultipleSymbols('-',2*size);

            for (int i = 1; i <= size - 2; i++)
            {
                PrintSquareBody(size);
            }

            PrintMultipleSymbols('-', 2 * size);

            Console.ReadLine();
        }
    }
}
