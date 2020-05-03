using System;
class Program
{
    static void Main()
    {
        // non-nullable value types
        bool ? AreYouAMajor = null;
        if (AreYouAMajor == true)
        {
            Console.WriteLine("He is a major");
        }
        else if (AreYouAMajor == false)
        {
            Console.WriteLine("He is a not a major");
        }
        else
        {
            Console.WriteLine("User did not answer the question");
        }
        /* without null coalescing operator
        int? TicketsonSale = null;
        int AvailableTickets;
        if(TicketsonSale == null)
        {
            AvailableTickets = 100;
        }
        else
        {
            AvailableTickets = (int)TicketsonSale;
        }
        Console.WriteLine("Available Ticket = {0}", AvailableTickets);*/

        //with null coalescing operator
        int? TicketsonSale = null;
        int AvailableTickets = TicketsonSale ?? 0;
        Console.WriteLine("Availble Tickets = {0}", AvailableTickets);
    }
}

