using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int Number = int.Parse(Console.ReadLine());
        if (Number == 1)
        {
            Console.WriteLine("The Number is One.");
        }
        else if (Number == 2)
        {
            Console.WriteLine("The Number is Two.");
        }
        else if (Number == 3)
        {
            Console.WriteLine("The Number is Three.");
        }

        else
        {
            Console.WriteLine("Your number is not between 1 and 3");
        }
    }
}
