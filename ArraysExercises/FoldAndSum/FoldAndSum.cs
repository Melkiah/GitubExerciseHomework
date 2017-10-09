using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            int main = inputArray.Length / 2;
            int k = main / 2;
            int count = 0;

            int[] middleArr = new int[main];
            int[] sidesArr = new int[main];

            for (int i = k; i < k+main; i++)
            {
                middleArr[count] += int.Parse(inputArray[i]);
                count++;
            }
            count = 0;

            for(int i = k-1; i >= 0; i--)
            {
                sidesArr[count] += int.Parse(inputArray[i]);
                count++;
            }
            
            for (int i = inputArray.Length-1; i >= k+main; i--)
            {
                sidesArr[count] += int.Parse(inputArray[i]);
                count++;
            }

            for (int i = 0; i < main; i++)
            {
                Console.Write("{0} ", middleArr[i]+sidesArr[i]);
            }
        }
    }
}
