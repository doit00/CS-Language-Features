using System;
using static System.Console;

namespace CSLangFeatures.CS6
{
    static class CS6Features
    {
        public static void StaticUsing()
        {
            //Console class required
            Console.WriteLine("classic call");

            //Console class referenced by using static 
            WriteLine("using static call");
        }

        public static void ImmutableAutoProperties()
        {
            Car bmw = new Car("BMW");
            Console.WriteLine("{0}", bmw.Make);
            //Make property is read only inside and outside of class:
            //Car mercedes = new Car("") {Make = "Mercedes" };

        }
        public static void ExpressionBodiedMembers()
        {
            Order shopOrder = new Order();
            Console.WriteLine("Order date {0}, hours left for delivery {1}"
                , shopOrder.OrderDate
                , shopOrder.GetDeliveryHoursLeft());
        }

        public static void NameOfOperator()
        {
            Car fiat = new Car("FIAT");
            Console.WriteLine("{0}: {1}",nameof(fiat.Make),fiat.Make );
        }

        public static void StringInterpolation()
        {
            var computerName = Environment.MachineName;
            var user = Environment.UserName;
            var os = Environment.OSVersion;
            var currentInfo = $"User {user} on {computerName}, os: {os.VersionString} at {DateTime.Today:d}";
            Console.WriteLine(currentInfo);

        }
        public static void NullConditionalOperator()
        {
            HotelReservation currentReservation = new HotelReservation();
            //NullReferenceException:
            //Console.WriteLine(currentReservation.Hotel.Name);
            // ?. checks currentReservation and Hotel for nullability
            Console.WriteLine(currentReservation?.Hotel?.Name);
        }



    }

}