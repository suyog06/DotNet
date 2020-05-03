using System;

class Customer
{
    string Fname;
    string Lname;

    public Customer()
        : this  ("No First Name Provided", "No Last Name Provided")
    {
        
    }
        
    public Customer(string FirstName, string LastName)
    {
        Fname = FirstName;
        Lname = LastName;
    }
    public void FullName()
    {
        Console.WriteLine("Full Name: {0}", Fname + " " + Lname);
    }
}
class Program
{
    static void Main()
    {
        Customer C1 = new Customer("Suyog", "Shelar");
        C1.FullName();
        
    }
}
