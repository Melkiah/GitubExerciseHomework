using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> useFullResourses = new Dictionary<string, int>();
            Dictionary<string, int> useLessResourses = new Dictionary<string, int>();
            useFullResourses.Add("shards", 0);
            useFullResourses.Add("fragments", 0);
            useFullResourses.Add("motes", 0);

            while (true)
            {
                List<string> inputResourses = Console.ReadLine().Split().ToList();

                for (int i = 1; i < inputResourses.Count; i += 2)
                {
                    string resourse = inputResourses[i].ToLower();
                    int qty = int.Parse(inputResourses[i - 1]);

                    if (isUseless(resourse))
                    {
                        if (!ContainsResourse(useLessResourses, resourse))
                        {
                            useLessResourses.Add(resourse, qty);
                        }
                        else
                        {
                            useLessResourses[resourse] += qty;
                        }

                        continue;
                    }

                    if (!ContainsResourse(useFullResourses, resourse))
                    {
                        useFullResourses.Add(resourse, qty);
                    }
                    else
                    {
                        useFullResourses[resourse] += qty;
                    }

                    if (LegendaryGained(useFullResourses[resourse]))
                    {
                        useFullResourses[resourse] -= 250;
                        PrintFound(resourse, useFullResourses, useLessResourses);
                        return;
                    }
                }

            }

        }

        public static void PrintFound(string resourse, Dictionary<string, int> useFullResourses, Dictionary<string, int> useLessResourses)
        {
            string legendayItemName = "";
            switch (resourse)
            {
                case "shards": legendayItemName = "Shadowmourne"; break;
                case "fragments": legendayItemName = "Valanyr"; break;
                case "motes": legendayItemName = "Dragonwrath"; break;
            }
            Console.WriteLine($"{legendayItemName} obtained!");
            var remaining = useFullResourses.OrderByDescending(x => x.Value).ThenBy(x =>x.Key);
            var junk = useLessResourses.OrderBy(x =>x.Key);
            foreach (var resource in remaining)
            {
                Console.WriteLine($"{resource.Key}: {resource.Value}");
            }
            foreach (var j in junk)
            {
                Console.WriteLine($"{j.Key}: {j.Value}");
            }
        }

        public static bool LegendaryGained(int quantity)
        {
            if (quantity > 250)
            {
                return true;
            }

            return false;
        }

        public static bool isUseless(string resourse)
        {
            if (resourse == "fragments" || resourse == "shards" || resourse == "motes")
            {
                return false;
            }

            return true;
        }

        public static bool ContainsResourse(Dictionary<string, int> resourcesMined, string resourse)
        {
            foreach (var item in resourcesMined.Keys)
            {
                if (item == resourse)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
