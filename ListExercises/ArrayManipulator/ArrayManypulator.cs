using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManypulator
    {
        static void PrintList(List<int> list)
        {            
            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }

        static void AddToList(List<int> list, string index, string number)
        {
            int ind = int.Parse(index);
            int num = int.Parse(number);
            list.Insert(ind, num);
        }
       

        static void ContainsInList(List<int> list, string number)
        {
            int num = int.Parse(number);
            if (!list.Contains(num))
            {
                Console.WriteLine("-1");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == num)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }

        static void RemoveInList(List<int> list, string number)
        {
            int num = int.Parse(number);
            list.RemoveAt(num);
        }

        static void ShiftList(List<int> list, string index)
        {
            int ind = int.Parse(index);
            for (int i = 0; i < ind; i++)
            {
                int member = list[0];
                list.RemoveAt(0);
                list.Insert(list.Count, member);
            }
        }

        static void SumPairs(List<int> list)
        {
            for (int i = 0; i < list.Count; i+=2)
            {                
                if(i == list.Count - 1)
                {
                    break;
                }
                else
                {
                    int leftMember = list[i];
                    int rightMember = list[i + 1];
                    list[i] = leftMember + rightMember;
                    list[i + 1] = int.MinValue;
                }
            }

            list.RemoveAll(x => x == int.MinValue);
        }

        static void Main(string[] args)
        {
            const string add = "add", 
                         addMany = "addMany", 
                         contains = "contains", 
                         remove = "remove", 
                         shift = "shift", 
                         sumPairs = "sumPairs", 
                         print = "print";

            List<int> inputArray = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case add:
                        AddToList(inputArray, command[1], command[2]);
                        break;

                    case addMany:
                        
                        for (int i = command.Length -1; i >= 2; i--)
                        {                            
                            AddToList(inputArray, command[1], command[i]);                            
                        }
                        break;

                    case contains:
                        ContainsInList(inputArray, command[1]);
                        break;

                    case remove:
                        RemoveInList(inputArray, command[1]);
                        break;

                    case print:
                        PrintList(inputArray);
                        return;

                    case sumPairs:
                        SumPairs(inputArray);
                        break;

                    case shift:
                        ShiftList(inputArray, command[1]);
                        break;

                    default: Console.WriteLine("Invalid Input!"); break;
                }

            }
        }
    }
}
