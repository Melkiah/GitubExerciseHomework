using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            const string Delete = "Delete", Insert = "Insert", Odd = "Odd", Even = "Even";

            List<int> inputArray = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case Delete:

                        int numToDelete = int.Parse(command[1]);
                        inputArray.RemoveAll(x => x== numToDelete); break;

                    case Insert:

                        int numToInsert = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        inputArray.Insert(index, numToInsert); break;

                    case Odd:

                        foreach (var item in inputArray)
                        {
                            if (item % 2 != 0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();

                        return;
                        
                    case Even:

                        foreach (var item in inputArray)
                        {
                            if (item % 2 == 0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();

                        return;

                    default: Console.WriteLine("Invalid Command!");
                        break;
                }
            }
        }
    }
}
