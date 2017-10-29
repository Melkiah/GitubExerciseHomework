using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTag
{
    class ReplaveTag
    {
        static void Main(string[] args)
        {
            List<string> htmlLines = new List<string>();
            string replaceString = @"[URL href=$1]$2[/URL]";
            string regex = @"<a.*?href.*?=(.*?)>(.*?)<\/a>";
            string input = Console.ReadLine();

            while (input != "end")
            {
                input = Regex.Replace(input, regex, replaceString);
                htmlLines.Add(input);
                input = Console.ReadLine();
            }

            foreach (string tag in htmlLines)
            {
                Console.WriteLine(tag);
            }
        }
    }
}
