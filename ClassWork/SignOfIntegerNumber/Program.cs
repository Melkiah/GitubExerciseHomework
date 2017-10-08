using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void PrintSignOfNumber(int number)
        {
            string result;
            if(number < 0)
            {
                result = "negative";
            }
            else if(number > 0)
            {
                result = "positive";
            }
            else
            {
                result = "zero";
            }

            Console.WriteLine("The number {0} is {1}" ,number, result );
        }

        static void Main(string[] args)
        {
            int numberToBeDefined = int.Parse(Console.ReadLine());
            PrintSignOfNumber(numberToBeDefined);
        }
    }
}
