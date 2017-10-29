using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexMatchHexaNumbers
{
    class MatchHexaNumbers
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?:0x)?[0-9A-F]+\b";
            string input = "1F 0xG 0x1F G 0x4G 4G 0xAB 0xFG FG 0x10   10 AB  FF";

            MatchCollection matchHexas = Regex.Matches(input, regex);

            string[] collection = matchHexas.Cast<Match>().Select(x => x.Value.ToString()).ToArray();

            Console.WriteLine(String.Join(", ", collection));
        }
    }
}
