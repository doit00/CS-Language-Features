using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLangFeatures.CS4
{
    static class CS4Features
    {
        public static void LateBindingWithDynamic()
        {
            
             var comType = Type.GetTypeFromProgID("WScript.Shell");
             dynamic oTemp = Activator.CreateInstance(comType);
             string computerName = oTemp.Environment("PROCESS").Item("COMPUTERNAME");
             Console.WriteLine(computerName);

        }
        public static void NamedArguments()
        {
             TicketProcessor.PrintTicketCount(to: DateTime.Today, from: DateTime.MinValue);
        }
        public static void OptionalArguments()
        {
            TicketProcessor.GetTicketDetails(1, DateTime.Today);

        }
    }
}

