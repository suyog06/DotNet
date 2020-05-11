using System;
using System.Collections.Generic;

namespace SortingComplexTypes
{
    public class Program
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
                Name = "John",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer> listCutomers = new List<Customer>();
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);

            Console.WriteLine("Customers before sorting");
            foreach (Customer customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }
            listCutomers.Sort();

            Console.WriteLine("Customers after sorting");
            foreach (Customer customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }

            SortByName sortByName = new SortByName();
            listCutomers.Sort(sortByName);

            Console.WriteLine("Customers after sorting by Name");
            foreach (Customer customer in listCutomers)
            {
                Console.WriteLine(customer.Name + " - " + customer.Salary);
            }
        }
    }
    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer obj)
        { 
           return this.Salary.CompareTo(obj.Salary);
        }
    }
    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

}
