﻿using System;

namespace Generics
{
    class Program
    {
        public static void Main()
        {
            bool Equal = Calculator.AreEqual<int >(4,4);

            if(Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        
    }
    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
