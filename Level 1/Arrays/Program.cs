using System;
class Program
{
    static void Main()
    {
        //Assign values on different lines
        int[] EvenNumbers = new int[3];
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;
        Console.WriteLine(EvenNumbers[2]);

        //Assign values in the same line
        int[] OddNumbers = { 1, 3, 5, 7, 9 };
        Console.WriteLine(OddNumbers[3]);
    }
}

