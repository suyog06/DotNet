using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Enter a Number");
        int Number = int.Parse(Console.ReadLine());
        int start = 0;
        while (start <= Number)
        {
            Console.Write(start + " ");
            start += 2;
        }
    }
}
