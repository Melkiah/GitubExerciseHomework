using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintName
{
    class Program
    {
        static void PrintHelloName(string input)
        {
            Console.WriteLine("Hello, {0}!", input);
        }

        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            PrintHelloName(input);
            //String stopTheConsole = Console.ReadLine();
        }
    }
}
