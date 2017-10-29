using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumbers
{
    class MatchPhoneNumbers
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |-)2(\1)\d{3}(\1)\d{4}\b";
            string input = "+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222";

            MatchCollection matchedPhonenumbers = Regex.Matches(input, regex);

            string[] collection = matchedPhonenumbers.Cast<Match>().Select(x => x.Value.ToString()).ToArray();

            Console.WriteLine(String.Join(", ", collection));            
        }
    }
}
