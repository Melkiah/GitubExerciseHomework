using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class PrintReceipt
    {    
        static void PrintMultipleSymbols(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        static void PrintHeader()
        {
            PrintMultipleSymbols('-',30);
            Console.WriteLine("CASH RECEIPT");            
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintFooter()
        {
            PrintMultipleSymbols('-', 30);
            Console.WriteLine("© SoftUni");
        }

        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}
