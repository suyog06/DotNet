using System;
class program
{
    static void Main()
    {
        /*Console.WriteLine("Enter a Number");
        int Number = int.Parse(Console.ReadLine());
        
        switch(Number)
        {
            case 10: 
                //Console.WriteLine("The Number is 10");
                //break;
            case 20:
                //Console.WriteLine("The Number is 20");
                //break;
            case 30:
                Console.WriteLine("The Number is {0}", Number);
                break;
            default:
                Console.WriteLine("Your Number is neither 10, 20 or 30");
                break;
        }*/

       
        int TotalCoffeeCost = 0;
        Start:
        Console.WriteLine("1- small, 2- medium, 3- large");
        Console.WriteLine("Enter your choice");
        int UserChoice = int.Parse(Console.ReadLine());

        switch(UserChoice)
        {
            case 1:
                Console.WriteLine("total cost = ${0}", TotalCoffeeCost += 10);
                break;
            case 2:
                Console.WriteLine("total cost = ${0}", TotalCoffeeCost += 20);
                break;
            case 3:
                Console.WriteLine("total cost = ${0}", TotalCoffeeCost += 30);
                break;
            default:
                Console.WriteLine("The Choice {0} is Invalid", UserChoice);
                goto Start;
        }
        Decide:
        Console.WriteLine("If you want to buy more coffee enter Yes or No");
        string UserDecision = Console.ReadLine();
        switch (UserDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Please enter a valid decision");
                goto Decide;
        }
        Console.WriteLine("Bill Amount = ${0}", TotalCoffeeCost);
    }

}


