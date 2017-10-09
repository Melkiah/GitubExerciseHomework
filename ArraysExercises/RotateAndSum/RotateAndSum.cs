using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            string[] toRotate = Console.ReadLine().Split(' ');
            int rotations = int.Parse(Console.ReadLine());
            int arrayLength = toRotate.Length;

            string[] rotated = new string[arrayLength];
            int[] sumArray = new int[arrayLength];

            for (int j = 1; j <= rotations; j++)
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    rotated[(i + j) % arrayLength] = toRotate[i];
                }

                for (int i = 0; i < arrayLength; i++)
                {
                    sumArray[i] += int.Parse(rotated[i]);
                }
            }

            foreach (int number in sumArray)
            {
                Console.Write(number +" ");
            }
        }
    }
}
