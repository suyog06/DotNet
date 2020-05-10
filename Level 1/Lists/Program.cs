using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            Customer[] arrayCustomers = new Customer[3];
            arrayCustomers[0] = customer1;
            arrayCustomers[1] = customer2;
            arrayCustomers[2] = customer3;

            List<Customer> listCustomers = arrayCustomers.ToList();
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            Customer[] arrayAllCustomers = listCustomers.ToArray();
            foreach (Customer c in arrayAllCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------------");


            Dictionary<int, Customer> dictionaryCustomers = listCustomers.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Customer> keyValuePairCustomers in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", keyValuePairCustomers.Key);
                Customer c = keyValuePairCustomers.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------------");


            if (listCustomers.Contains(customer2))
            {
                Console.WriteLine("Customer2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Customer2 object does not exist in the list");
            }
            Console.WriteLine("------------------------------------------------------");
            if (listCustomers.Exists(x => x.Name.StartsWith("M")))
            {
                Console.WriteLine("List contains customer whose name starts with M");
            }
            else
            {
                Console.WriteLine("List does not contain a customer whose name starts with M");
            }
            Console.WriteLine("------------------------------------------------------");
            Customer cust = listCustomers.Find(customer => customer.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            Console.WriteLine("------------------------------------------------------");
            Customer lastMatch = listCustomers.FindLast(customer => customer.Salary > 5000);

            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", lastMatch.ID, lastMatch.Name, lastMatch.Salary);
            Console.WriteLine("------------------------------------------------------");
            List<Customer> filteredCustomers = listCustomers.FindAll(customer => customer.Salary > 5000);
            foreach (Customer cstmr in filteredCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cstmr.ID, cstmr.Name, cstmr.Salary);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Index of the first matching customer object whose salary is greater 5000 =" +
                listCustomers.FindIndex(customer => customer.Salary > 5000));
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Index of the Last matching customer object whose salary is greater 5000 = " +
                listCustomers.FindLastIndex(customer => customer.Salary > 5000));
            Console.WriteLine("------------------------------------------------------");
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
