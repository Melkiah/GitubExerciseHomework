using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfElements
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            int bestLen = 0, bestStart = 0;
            int start = 0;
            int len = 1;

            int[] parsedArray = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                parsedArray[i] = int.Parse(inputArray[i]);
            }

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (parsedArray[i] >= parsedArray[i-1] + 1)
                {
                    len++;
                }
                else
                {
                    len = 1;
                    start = i;
                }

                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }

            }

            //Console.WriteLine(bestStart);
           // Console.WriteLine(bestLen);

            if (bestLen == 1 && bestStart == 1)
            {
                Console.WriteLine(parsedArray[0]);
            }
            else
            {
                for (int i = bestStart; i <= bestLen + bestStart - 1; i++)
                {
                    Console.Write(parsedArray[i] + " ");
                }
                Console.WriteLine();
            }

            
        }
    }
}
