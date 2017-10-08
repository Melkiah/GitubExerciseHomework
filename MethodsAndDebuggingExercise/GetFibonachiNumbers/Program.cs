using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFibonachiNumbers
{
    class Program
    {
        static int PrintFibonachi(int n)
        {
            int first = 1;
            int second = 1;
            int current = 0;

            if(n == 0 || n == 1)
            {
                return 1;
            }

            for(int i = 2; i<=n; i++)
            {
                current = first + second;
                first = second;
                second = current;
            }

            return current;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintFibonachi(n));
            //String stopTheConsole = Console.ReadLine();
        }
    }
}
