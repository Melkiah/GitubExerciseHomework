using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfKSequece
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int sequenceLength = int.Parse(Console.ReadLine());

            int[] seq = new int[arraySize];
            seq[0] = 1;

            for(int i = 1; i < arraySize; i++)
            {
                if (i < sequenceLength)
                {
                    for (int j = 0; j <= i -1; j++)
                    {
                        seq[i] += seq[j];
                    }
                }
                else
                {
                    for (int j = i - sequenceLength; j <= i-1; j++)
                    {
                        seq[i] += seq[j];
                    }
                }                
            }

            foreach(int number in seq)
            {
                Console.Write(number + " ");
            }
        }
    }
}
