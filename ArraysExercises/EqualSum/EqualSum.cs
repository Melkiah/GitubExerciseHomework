using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSum
{
    class EqualSum
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;
            //int index = 0;
            bool isFound = false;

            for (int i = 0; i < inputArray.Length; i++) //10 5 5 99 3 4 2 5 1 1 4
            {
                for (int j = i - 1; j >= 0; j--)// sum to the left
                {
                    leftSum += inputArray[j];
                }

                for (int j = i + 1; j < inputArray.Length; j++) // sum to the right
                {
                    rightSum += inputArray[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }

                leftSum = 0;
                rightSum = 0;
            }

            //leftSum = -1;

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
