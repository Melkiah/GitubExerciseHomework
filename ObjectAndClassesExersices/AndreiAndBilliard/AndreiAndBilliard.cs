using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Orders { get; set; }

        public Customer(string name)
        {
            this.Name = name;
            this.Orders = new Dictionary<string, int>();
        }
    }

    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shopList = new Dictionary<string, decimal>();
            List<Customer> customerOrders = new List<Customer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();

                if (!shopList.ContainsKey(input[0]))
                {
                    shopList.Add(input[0], decimal.Parse(input[1]));
                }
                else
                {
                    shopList[input[0]] = decimal.Parse(input[1]);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("end of clients"))
                {
                    break;
                }

                string[] personsOrder = input.Split(',', '-');
                string name = personsOrder[0];
                string item = personsOrder[1];
                int qty = int.Parse(personsOrder[2]);

                if (ItemDoesntExist(item, shopList))
                {
                    continue;
                }

                Customer newCustomer = new Customer(name);

                if (!ContainsPerson(name, customerOrders))
                {
                    newCustomer.Orders.Add(item, qty);
                    customerOrders.Add(newCustomer);
                }
                else
                {
                    for (int i = 0; i < customerOrders.Count; i++)
                    {
                        if (customerOrders[i].Name == name)
                        {
                            if (customerOrders[i].Orders.ContainsKey(item))
                            {
                                customerOrders[i].Orders[item] += qty;
                            }
                            else
                            {
                                customerOrders[i].Orders.Add(item, qty);
                            }

                            break;
                        }
                    }
                }
            }

            decimal bill = 0;
            decimal totalBill = 0;

            foreach (var item in customerOrders.OrderBy(x => x.Name))
            {
                Console.WriteLine(item.Name);
                foreach (var order in item.Orders)
                {
                    decimal tempBill = order.Value * shopList[order.Key];
                    Console.WriteLine($"-- {order.Key} - {order.Value}");
                    bill += tempBill;
                }
                Console.WriteLine($"Bill: {bill:F2}");
                totalBill += bill;
                bill = 0;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        public static bool ItemDoesntExist(string item, Dictionary<string, decimal> shopList)
        {
            foreach (var product in shopList)
            {
                if (product.Key.Equals(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ContainsPerson(string name, List<Customer> ordersList)
        {
            foreach (var item in ordersList)
            {
                if (item.Name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
