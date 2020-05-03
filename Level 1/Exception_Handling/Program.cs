using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader  str= null;
        try 
        {
            str = new StreamReader(@"C:\Users\Suyog\Desktop\Test1.txt");
            Console.WriteLine(str.ReadToEnd());
            // Console.WriteLine("Hello World!");
        }

        catch(Exception exc)
        {
            Console.WriteLine("{0}", exc.Message);
        }
        finally
        {
            str.Close();
            Console.WriteLine("Finally Blocked!!");
        }

    }
}
