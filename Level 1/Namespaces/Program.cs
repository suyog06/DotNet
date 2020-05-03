using System;
using ProjectA.TeamA;

class Program
{
        static void Main()
    {
        ClassA.Print();
        ProjectA.TeamB.ClassA.Print();
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Print for team A");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Print for team B");
            }
        }
    }
}

