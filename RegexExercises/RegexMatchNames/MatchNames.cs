using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexMatchNames
{
    class MatchNames
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string input = "Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan	Ivanov";

            MatchCollection matchedNames = Regex.Matches(input, regex);

            foreach (Match item in matchedNames)
            {
                Console.WriteLine(item.Value + " ");
            }
        }
    }
}
