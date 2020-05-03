using System;
class Program
{
    static void Main()
    {
        //assignment operator
        int a = 10;
        int b = 5;
        //arithematic operator
        int res = a + b;
        Console.WriteLine("Result = {0}", res);
        //comparison operator
        if(a>=b)
        {
            Console.WriteLine("True");
        }
        //conditional operator
        if(a==10 && b==5)
        {
            Console.WriteLine("Totally true");
        }
        else if(a==10 || b==6)
        {
            Console.WriteLine("Partially true");
        }
        else
        {
            Console.WriteLine("Not True");
        }
        //ternary operator
        int Number = 15;
        bool IsNumber10 = Number == 10 ? true : false;
        Console.WriteLine("Number == 10 is {0}", IsNumber10);
    }
}
