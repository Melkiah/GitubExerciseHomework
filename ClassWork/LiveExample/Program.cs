using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveExample
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int swapVariable = a;
            a = b;
            b = swapVariable;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Swap(ref a, ref b);

            Console.Write(a + " " + b);
            Console.ReadLine();
        }
    }
}
