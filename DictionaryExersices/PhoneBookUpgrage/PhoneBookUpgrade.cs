using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBookUpgrade
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

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
                    case "ListAll":
                        foreach (var item in phoneBook)
                        {
                            Console.WriteLine("{0} -> {1}", item.Key, item.Value);

                        }

                        break;
                    case "END": return;
                        //default: Console.WriteLine("Invalid Input!"); break;

                }
            }
        }
    }
}
