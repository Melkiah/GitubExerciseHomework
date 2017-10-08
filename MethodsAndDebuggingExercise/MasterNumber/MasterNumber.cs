using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class MasterNumber
    {
        static bool isSymmetric(int number)
        {
            int temp, reverse = 0, remainder;
            temp = number;
            while (number > 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }

            if(temp == reverse)
            {
                return true;
            }

            return false;
        }

        static bool isSumOfDigits(int number)
        {
            int sum = 0;
            while(number != 0)
            {
                sum += number % 10;
                number = number / 10;
            }

            if(sum%7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        static bool hasOneEvenDigit(int number)
        {
            int digit = 0;
            while (number != 0)
            {
                digit = number % 10;
                if(digit % 2 == 0)
                {
                    return true;
                }
                number = number / 10;
            }

            return false;
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if(isSymmetric(i) && isSumOfDigits(i) && hasOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
