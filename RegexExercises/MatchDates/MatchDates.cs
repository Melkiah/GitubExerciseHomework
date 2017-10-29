using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            //string regex = @"\b(\d{2})([\/.-])([A-Z][a-z]{2})(\2)(\d{4})\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\b(?<day>\d{2})([\/.-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

            MatchCollection dates = regex.Matches(input);

            foreach (Match date in dates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
