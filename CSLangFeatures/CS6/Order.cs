using System;

namespace CSLangFeatures.CS6
{
    class Order
    {
        //expression bodied property
        public DateTime OrderDate => DateTime.Now;
        public DateTime MaxDeliveryDate => OrderDate.AddDays(4);
        //expression bodied method
        public int GetDeliveryHoursLeft() => (int)(MaxDeliveryDate - OrderDate).TotalHours;
        //expression bodied constructor are not available in CS6 but has been introduced by CS7

    }

}