using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayofntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];

            for(int i = 0; i < arraySize; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for(int i = arraySize - 1; i >= 0; i--)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
