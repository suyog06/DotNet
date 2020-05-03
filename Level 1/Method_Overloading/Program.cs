using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
        Add(2, 3, 4);
    }

    public static void Add(int a, int b)
    {
        Console.WriteLine("{0}", a + b);
    }
    public static void Add(int a, int b, int c)
    {
        Console.WriteLine("{0}", a + b + c);
    }
}

