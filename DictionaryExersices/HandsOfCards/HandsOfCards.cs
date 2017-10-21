using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class HandsOfCards
    {

        static int CalculateCardValue(string card)
        {
            int cardValue = 0;
            int power = 0, type = 0;

            switch (card[0])
            {
                case '2': power = 2; break;
                case '3': power = 3; break;
                case '4': power = 4; break;
                case '5': power = 5; break;
                case '6': power = 6; break;
                case '7': power = 7; break;
                case '8': power = 8; break;
                case '9': power = 9; break;
                case '1': power = 10; break;
                case 'J': power = 11; break;
                case 'Q': power = 12; break;
                case 'K': power = 13; break;
                case 'A': power = 14; break;
            }

            switch (card[card.Length - 1])
            {
                case 'S': type = 4; break;
                case 'H': type = 3; break;
                case 'D': type = 2; break;
                case 'C': type = 1; break;
            }
            return cardValue = type * power;
        }

        static int CalculateHandValue(List<string> hand)
        {
            int sumValue = 0;
            foreach (var card in hand)
            {
                sumValue += CalculateCardValue(card);
            }
            return sumValue;
        }

        static void Main(string[] args)
        {
            Dictionary<string, List<string>> playersLog = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new[] { ": ", ", "}, StringSplitOptions.RemoveEmptyEntries);

                string playerName = input[0];

                if (playerName == "JOKER")
                {
                    break;
                }

                List<string> cards = new List<string>();

                for (int i = 1; i < input.Length; i++)
                {
                    if (cards.Contains(input[i]))
                    {
                        continue;
                    }
                    else
                    {
                        cards.Add(input[i]);
                    }
                }

                if (playersLog.ContainsKey(playerName))
                {
                    foreach (var item in cards)
                    {
                        if (playersLog[playerName].Contains(item))
                        {
                            continue;
                        }
                        else
                        {
                            playersLog[playerName].Add(item);
                        }
                    }
                }
                else
                {
                    playersLog.Add(playerName, cards);
                }

            }

            foreach (var item in playersLog)
            {
                Console.WriteLine("{0}: {1}", item.Key, CalculateHandValue(item.Value));
            }
        }
    }
}
