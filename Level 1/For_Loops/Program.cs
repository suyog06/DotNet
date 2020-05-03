using System;

class Program
{
    static void Main()
    {
        int[] Numbers = { 101, 102, 103 };
        for(int i=0; i<Numbers.Length; i++)
        {
            Console.WriteLine(Numbers[i]);
        }
        

        foreach(int j in Numbers)
        {
            Console.WriteLine(j);
        }

        for(int k=0; k< 20; k++)
        {
            if (k % 2 == 1)
            {
                continue;
            }
            Console.WriteLine(k);
        }

    }
}

