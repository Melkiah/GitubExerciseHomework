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
            int largest = 0;
            int last = 0;
            int len = 1;

            for (int i = 0; i < inputArray.Length-1; i++)
            {
                if(inputArray[i].Equals(inputArray[i + 1]))
                {
                    len++;
                    if (len > largest)
                    {
                        largest = len;                        
                        last = i+1;
                    }
                }
                else
                {
                    len = 1;
                }
                
            }

            for (int i = last; i >= last-largest+1; i--)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
