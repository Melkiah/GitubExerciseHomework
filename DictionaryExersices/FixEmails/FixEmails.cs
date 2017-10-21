using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailsBook = new Dictionary<string, string>();
            string name = "";
            string email = "";

            int count = 1;

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("stop"))
                {
                    break;
                }

                if (count % 2 != 0)
                {
                    name = input;
                }
                else
                {
                    email = input;
                    emailsBook.Add(name, email);
                }
                count++;
            }


            Dictionary<string, string> clearedBook = new Dictionary<string, string>();
            foreach (var item in emailsBook)
            {
                if (!item.Value.Contains(".us") && !item.Value.Contains(".uk") &&
                    !item.Value.Contains(".US") && !item.Value.Contains(".UK"))
                {
                    clearedBook.Add(item.Key, item.Value);
                }
            }

            foreach (var item in clearedBook)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
