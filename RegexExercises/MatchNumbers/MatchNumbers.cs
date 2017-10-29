using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            MatchCollection numbers = regex.Matches(input);

            foreach (Match number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
