using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Diagnostics.Contracts;

namespace MyNamespace
{
    class MyClass
    {

        static void Main(string[] args)
        {
            Contract.Assume(args.Length == 0);
            BaseReservation b = new BaseReservation();
            Console.WriteLine(b.ID);
        }

    }

    

    class BaseReservation
    {
        public int ID;
        public string Description => "Default Descriptions";
        public DateTime Registered => DateTime.Today;
        public string GetDesc() => $"ID {ID}, Registered {Registered.ToShortDateString()}";
        public BaseReservation()
        {
            ValidateID(ID);
        }
        [ContractAbbreviator]
        void ValidateID(int id)
        {
            Contract.Assume(id > 0,"id should be gt 0");
        }

    }
    class HotelReservation : BaseReservation
    {
        public string HotelName;
        public DateTime From;
        public DateTime To;
        public bool OverbookingAllowed;

    }
    class FlightReservation : BaseReservation
    {
        public string Source;
        public string Destination;
        public string FlightClass;
        public DateTime Departure;
        public DateTime Arrival;

    }

  

}