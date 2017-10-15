using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfReversedNumbers
{
    class SumOfReversedNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0; int reversed = 0; int number;

            for (int i = 0; i < numbersArray.Count; i++)
            {
                int lastdigit = 0;
                number = numbersArray[i];
                while (number > 0)
                {
                    lastdigit = number % 10;
                    reversed = reversed * 10 + lastdigit;
                    number /= 10;
                }

                sum += reversed;
                reversed = 0;
            }

            Console.WriteLine(sum);
        }
    }
}
