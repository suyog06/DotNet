using System;

class Program
{
    public static void Main()
    {
        Program p = new Program();
        p.EvenNumbers(10);

        //output parameter
        int sum = 0, product = 0;
        Program.Calculate(2, 3, out sum, out product);
        Console.WriteLine("\n Sum = {0} Prodcut = {1}",sum, product);

        int i = 0, k = 0;

        //pass by value
        Program.ByValue(i);
        Console.WriteLine(i);

        //pass by reference
        Program.ByRef(ref k);
        Console.WriteLine(k);

        //parameter array
        int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        ParamsMethod(Numbers);

    }

    public static void ByValue(int j)
    {
        j = 101;
    }

    public static void ByRef(ref int l)
    {
        l = 101;
    }
    public static void Calculate(int f, int s, out int sum, out int product)
    {
        sum = f + s;
        product = f * s;

    }
    public void EvenNumbers(int Target)
    {
        for(int start = 0; start<= Target; start++)
        {
            if(start %2 == 0)
            {
                Console.WriteLine(start);
            }
        }
    }
    public static void ParamsMethod(params int [] Number)
    {
        Console.WriteLine("There are {0} elements in an array", Number.Length);

        foreach(int i in Number)
        {
            Console.WriteLine(i);
        }
    }
}
