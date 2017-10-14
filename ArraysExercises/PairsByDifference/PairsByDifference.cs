using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());

            int pairsCount = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] - inputArray[j] == difference || inputArray[j] - inputArray[i] == difference)  //1 5 3 4 2
                    {
                        pairsCount++;
                    }
                }
            }

            Console.WriteLine(pairsCount);
        }
    }
}
