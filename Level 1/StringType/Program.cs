using System;

class Program
{
    static void Main()
    {
        //escape sequence
        string name = "\"Suyog\"";           
        Console.WriteLine(name);
        string path = "C: \\desktop\\suyog\\DotNet";
        Console.WriteLine(path);
        //new line
        string numbers = "one\ntwo\nthree";
        Console.WriteLine(numbers);
        //verbatim literal
        string path1 = @"C: \desktop\suyog\DotNet";
        Console.WriteLine(path1);
    }
}
