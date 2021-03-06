﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercises
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            int shortest, rightCounter = 0, leftCounter = 0;            

            shortest = Math.Min(firstArray.Length, secondArray.Length);         

            for (int i = 0; i < shortest; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    rightCounter++;
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
                    leftCounter++;
                    firstArrayLength--;
                    secondArrayLength--;
                }
                else
                {
                    break;
                }
            }

                 
            Console.WriteLine(Math.Max(rightCounter,leftCounter));
        }
    }
}
