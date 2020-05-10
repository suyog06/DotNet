using System;
using System.Runtime.InteropServices;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 20, new int[] {30,40,50});
        }
        public static void Add(int FNumber, int SNumber, [Optional] int[] restNumbers)
        {
            int result = FNumber + SNumber;
            if (restNumbers != null)
            {
                foreach(int i in restNumbers)
                {
                    result += i;
                }
                Console.WriteLine("Result = {0}", result);
            }
        }

    }
}
