using System;
using System.Threading;

namespace ThreadStartDelegate
{
    class Program
    {
        public static void Main()
        {
            Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));
            T1.Start();
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
