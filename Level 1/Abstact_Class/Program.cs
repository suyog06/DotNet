using System;

public abstract class Customer
{
    public abstract void Print();
}
class Program : Customer
{
    public override void Print()
    {
        Console.WriteLine("Print sucsessful");
    }
    static void Main()
    {
        Program P1 = new Program();
        P1.Print();
    }
}
