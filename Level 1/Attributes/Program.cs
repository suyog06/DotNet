using System;
using System.Collections.Generic;
public class MainClass
{
    public static void Main()
    {
        Console.WriteLine(Calculator.Add(new List<int>() { 10, 15, 20 }));
        
    }
}


public class Calculator
{
    [Obsolete("Use Add(List<int> Numbers) instead")]
    public static int Add(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }
    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach (int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }
}