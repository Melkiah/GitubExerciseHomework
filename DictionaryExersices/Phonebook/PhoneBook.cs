using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "S":
                        if (phoneBook.ContainsKey(command[1]))
                        {
                            Console.WriteLine("{0} -> {1}", command[1], phoneBook[command[1]]);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", command[1]);
                        }

                        break;
                    case "A":
                        if (phoneBook.ContainsKey(command[1]))
                        {
                            phoneBook.Remove(command[1]);
                            phoneBook.Add(command[1], command[2]);
                        }
                        else
                        {
                            phoneBook.Add(command[1], command[2]);
                        }
                        break;
                    case "END": return;
                        //default: Console.WriteLine("Invalid Input!"); break;

                }
            }
        }
    }
}
