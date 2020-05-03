using System;


class Program
{
    static void Main()
    {
        /*string choice = string.Empty;
        do
        {

            Console.WriteLine("Please enter your target");
            int target = int.Parse(Console.ReadLine());
            int start = 0;
            while (start <= target)
            {
                Console.Write(start + " ");
                start += 2;
            }
            do
            {
                Console.WriteLine("\n If you want to continue press Yes. To terminate press No");
                choice = Console.ReadLine().ToUpper();
                if (choice != "YES" && choice != "NO")
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (choice != "YES" && choice != "NO");
        } while (choice == "YES");*/

        int choice = 0;
        string decide = string.Empty;
        int totalcoffeecost = 0;
        do
        {
            Console.WriteLine("Please enter your choice \n 1: small 2: medium 3: large");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                totalcoffeecost += 10;
            }
            else if (choice == 2)
            {
                totalcoffeecost += 20;
            }
            else if (choice == 3)
            {
                totalcoffeecost += 30;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine("Total Cost = {0}", totalcoffeecost);

            do
            {
                Console.WriteLine("Do you want to buy more coffee??");
                Console.WriteLine("Yes or No");
                decide = Console.ReadLine().ToUpper();
                if (decide != "YES" && decide != "NO")
                {
                    Console.WriteLine("Invalid Decision");
                }
            } while (decide != "YES" && decide != "NO"); 
        } while (decide == "YES");
        Console.WriteLine("Bill Amount = {0}", totalcoffeecost);
    }
}



   