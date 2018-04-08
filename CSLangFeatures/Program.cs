using CSLangFeatures.CS4;
using CSLangFeatures.CS5;
using CSLangFeatures.CS6;
using CSLangFeatures.CS7;
using System;

namespace CSLangFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select C# language verision (4-7):");
            var version = Console.ReadLine();
            switch (version){
                case "4":
                    CS4Demos();
                    break;
                case "5":
                    CS5Demos();
                    break;
                case "6":
                    CS6Demos();
                    break;
                case "7":
                    CS7Demos();
                    break;
                default:
                    break;
            }
        }

        private static void CS4Demos()
        {
            CS4Features.LateBindingWithDynamic();
            CS4Features.NamedArguments();
            CS4Features.OptionalArguments();
        }

        private static void CS5Demos()
        {
            CS5Features.CallerMemberName();
            CS5Features.AsyncDemo();
        }

        private static void CS6Demos()
        {
            CS6Features.StaticUsing();
            CS6Features.ImmutableAutoProperties();
            CS6Features.ExpressionBodiedMembers();

            CS6Features.GetMemberName();
            CS6Features.StringInterpolation();
            CS6Features.NullConditionalOperator();
        }

        private static void CS7Demos()
        {
            CS7Features.ImplicitOutParameters();
            CS7Features.TypePatternMatching();
            CS7Features.SwitchFilters();

            //tuples
            CS7Features.SimpleTuple();
            CS7Features.TupleAsAReturnType();
            CS7Features.TupleDeconstruction();

            CS7Features.LocalFunctions();
            CS7Features.IntLiterals();
            CS7Features.ReturnByRef();
            CS7Features.ExceptionsAsExpressions();
        }
    }
}
