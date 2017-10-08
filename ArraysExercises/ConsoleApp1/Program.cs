using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            int rightCount = 0;
            int leftCount = 0;
            int shortest = Math.Min(firstArray.Length, secondArray.Length);
            for (int i = 0; i < shortest; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }
            int firstArrayLength = firstArray.Length - 1;
            int secondArrayLength = secondArray.Length - 1;

            for (int i = shortest; i > 0; i--)
            {
                if (firstArray[firstArrayLength] == secondArray[secondArrayLength])
                {
                    leftCount++;
                    firstArrayLength--;
                    secondArrayLength--;
                }
                else
                {                    
                    break;
                }
            }

            Console.WriteLine(Math.Max(rightCount,leftCount));
        }
    }
}