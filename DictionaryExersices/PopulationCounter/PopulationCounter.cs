using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class City
    {
        public string Name { get; set; }
        public long Population { get; set; }

        public City(string name, int population)
        {
            this.Name = name;
            this.Population = population;
        }
    }

    class Country
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }

        public Country (string name)
        {

            this.Name = name;
            this.Cities = new List<City>();
        }

        

        public long TotalPopulation
        {
            get
            {
                long population = 0;
                foreach (var city in this.Cities)
                {
                    population += city.Population;
                }

                return population;
            }
        }
    }

    class PopulationCounter
    {
        static void Main(string[] args)
        {
            List<Country> countryList = new List<Country>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('|').ToArray();

                if (input[0].Equals("report"))
                {
                    break;
                }

                string country = input[1];
                string city = input[0];
                int population = int.Parse(input[2]);

                City inputCity = new City(city, population);
                Country inputCountry = new Country(country);


                if (!ContainsCountry(countryList, inputCountry))
                {
                    inputCountry.Cities.Add(inputCity);
                    countryList.Add(inputCountry);
                }
                else
                {
                    for (int i = 0; i < countryList.Count; i++)
                    {
                        if (countryList[i].Name == country)
                        {
                            countryList[i].Cities.Add(inputCity);
                        }
                    }
                }
            }

            var orderedList = countryList.OrderByDescending(x => x.TotalPopulation);

            foreach (var item in orderedList)
            {
                Console.WriteLine($"{item.Name} (total population: {item.TotalPopulation})");
                var list = item.Cities.OrderByDescending(x => x.Population);
                foreach (var city in list)
                {
                    Console.WriteLine($"=>{city.Name}: {city.Population}");
                }
            }
        }

        public static bool ContainsCountry(List<Country> countryList, Country inputCountry)
        {
            foreach (var item in countryList)
            {
                if (item.Name == inputCountry.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
