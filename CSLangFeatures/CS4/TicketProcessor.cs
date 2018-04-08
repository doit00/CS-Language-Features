using System;

namespace CSLangFeatures.CS4
{
    class TicketProcessor
    {
        public static void PrintTicketCount(DateTime from, DateTime to)
        {
            Console.WriteLine("Printing ticket count from {0} to {1}",from,to);
        }
        public static void GetTicketDetails(int id, DateTime date , bool isconfirmed =true )
        {
            Console.WriteLine("Ticket {0} for {1} is confirmed {2}",id,date,isconfirmed);
        }

    }
}

