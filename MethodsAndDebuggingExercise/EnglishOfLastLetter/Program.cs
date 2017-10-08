using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishOfLastLetter
{
    class Program
    {
        static int GetLastDigit(long number)
        {
            return (int)(number % 10);
        }

        static void PrintDigitInEnglish(int digit)
        {
            switch (digit)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                case 0: Console.WriteLine("zero"); break;
            }
        }

        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            int lastDigit = GetLastDigit(Math.Abs(input));
            PrintDigitInEnglish(lastDigit);
            //String stopTheConsole = Console.ReadLine();
        }
    }
}
