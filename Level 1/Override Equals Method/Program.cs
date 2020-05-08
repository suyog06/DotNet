using System;

namespace Override_Equals_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 20;
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));
        }
        public enum Direction
        {
            East = 1,
            West = 2,
            North = 3,
            South = 4
        }
    }
}
