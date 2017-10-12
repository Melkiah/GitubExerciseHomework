using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] parsedArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                parsedArray[i] = int.Parse(inputArray[i]);
            }

            int largest = 0;
            int last = 0;
            int len = 1;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int left = parsedArray[i];
                int right = parsedArray[i + 1] - 1;

                if (left == right)
                {
                    len++;
                    if (len > largest)
                    {
                        largest = len;
                        last = i + 1;
                    }
                }
                else
                {
                    len = 1;
                }

            }

            for (int i = last - largest +1; i <= last ; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
    }