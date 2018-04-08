using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CSLangFeatures.CS7
{
    static class CS7Features
    {
        public static void ImplicitOutParameters()
        {
            // day and date variables has not been declared in advance
            GetWeekday(out DayOfWeek day, out DateTime date);
            Console.WriteLine($"Today is {day} - {date.ToShortDateString()}");

        }
        public static void GetWeekday(out DayOfWeek day, out DateTime date)
        {
            day = DateTime.Today.DayOfWeek;
            date = DateTime.Today.Date;
        }
        public static void TypePatternMatching()
        {
            object x;
            x = 1;
            //old way is + cast operator
            if (x is int)
            {
                Console.WriteLine($"x is int {(int)x}");
            }
            //new way is + type pattern matching
            if (x is int y)
            {
                Console.WriteLine($"{y}");
            }

        }
        public static void SwitchFilters()
        {
            DayOfWeek d = DateTime.Today.DayOfWeek;
            bool isWorkingSaturday = true;
            switch (d)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine($"Working day {d}");
                    break;
                case DayOfWeek.Saturday when (isWorkingSaturday):
                    Console.WriteLine($"Still working day {d}");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine($"non-working day {d}");
                    break;

                default:
                    break;
            }
        }

        public static void SimpleTuple()
        {
            Tuple<int, string, DateTime> customer =
              new Tuple<int, string, DateTime>(1, "John", DateTime.Today);

            Console.WriteLine($"customer {customer.Item2} last visit {customer.Item3.ToShortDateString()}");

        }
        public static void TupleAsAReturnType()
        {
            var customer = GetCustomerTuple();
            Console.WriteLine($"customer {customer.name} last visit {customer.lastVisit.ToShortDateString()}");
        }
        // Install-Package System.ValueTuple
        private static (int id, string name, DateTime lastVisit) GetCustomerTuple()
        {
            return (1, "John", DateTime.Today.AddDays(-2));
        }

        public static void TupleDeconstruction()
        {
            var customer = GetCustomerTuple();
            //var - assigns tuple parts to individual variables
            var (id, name, lastVisit) = customer;
            Console.WriteLine($"customer {name} last visit {lastVisit.ToShortDateString()}");
        }
        public static void LocalFunctions()
        {
            var numbers = Enumerable.Range(1, 10);
            Console.WriteLine( $"The sum of numbers is {Sum(numbers)} average is {Avg(numbers)}" );
            //local Sum function
            int Sum(IEnumerable<int> nums)
            {
                return  numbers.Sum();
            }
            //local expression bodied Avg function
            int Avg(IEnumerable<int> nums) => (int)nums.Average();
        }
        public static void IntLiterals()
        {
            int number = 1_234_989;
            Console.WriteLine($"number is {number}");
        }
        public static void ReturnByRef()
        {
            int[] numbers = {2,4,8,16};
            Console.WriteLine($"BEFORE: numbers[1]={numbers[1]}");
            ref int element = ref Susbstitute(numbers,4);
            element = 0;
            Console.WriteLine($"AFTER: numbers[1]={numbers[1]}");

        }

        private static ref int Susbstitute(int[] numbers, int valueToReturn)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == valueToReturn)
                {
                    return ref numbers[i];
                }
            }
            throw new IndexOutOfRangeException();
        }

        public static void ExceptionsAsExpressions()
        {
            Car ferrari = new Car("Ferrari");
            Car unknownCar = new Car(null);
        }
    }


}