using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSeuquenceWithLists
{
    class MaxSequenceWithLists
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int start = 0, len = 1, bestStart = 0, bestLen = 1;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
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

            for (int i = bestStart; i <= bestLen + bestStart - 1; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
