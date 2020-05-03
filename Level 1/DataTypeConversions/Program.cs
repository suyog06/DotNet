using System;
class Program
{
    static void Main()
    {
        //implicit conversion
        int i = 100;
        float f = i;
        Console.WriteLine(f);

        //explicit conversion
        float a = 1043.76F;
        int b = Convert.ToInt32(a); 
        Console.WriteLine(b);

        //string to int conversion
        string str = "100";
        int s = int.Parse(str);
        Console.WriteLine(s);
        
        // TryParse Method
        string str1 = "130HJ";
        int result = 0;
        bool IfConditionIsTrue = int.TryParse(str1, out result);
        if (IfConditionIsTrue)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}

