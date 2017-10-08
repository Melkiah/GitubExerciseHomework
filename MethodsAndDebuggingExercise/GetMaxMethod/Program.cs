using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxMethod
{
    class Program
    {
        static int GetMaxValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int bigger = GetMaxValue(a, b);

            Console.WriteLine(GetMaxValue(bigger, c));
            //String stopTheConsole = Console.ReadLine();

        }
    }
}
