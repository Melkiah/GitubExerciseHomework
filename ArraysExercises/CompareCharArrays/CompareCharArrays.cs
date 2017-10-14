using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool isFirst = false;

            if (firstArray.Length < secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] <= secondArray[i])
                    {
                        isFirst = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

                if (isFirst)
                {
                    foreach (var item in firstArray)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    foreach (var item in secondArray)
                    {
                        Console.Write(item);
                    }
                }
                else
                {
                    foreach (var item in secondArray)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    foreach (var item in firstArray)
                    {
                        Console.Write(item);
                    }
                }

            }
            else
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (secondArray[i] <= firstArray[i])
                    {
                        isFirst = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

                if (isFirst)
                {
                    foreach (var item in secondArray)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    foreach (var item in firstArray)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                }
                else
                {
                    foreach (var item in firstArray)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    foreach (var item in secondArray)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
