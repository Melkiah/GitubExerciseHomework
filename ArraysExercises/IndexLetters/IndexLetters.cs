using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexLetters
{
    class IndexLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            char[] alphabet = new char[26];
            char letter = 'a';

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = letter;
                letter++;
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i]==alphabet[j])
                    {
                        Console.WriteLine(input[i] + " -> " + j);
                        break;
                    }
                }
            }
            
        }
    }
}
