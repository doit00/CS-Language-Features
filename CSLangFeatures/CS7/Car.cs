using System;

namespace CSLangFeatures.CS7
{
    class Car
    {
        public string Make { get; }
        //Expression-bodied constructor member was not available for CS6
        public Car(string make) => 
            Make = make ?? throw new ArgumentException("Car make should not be null"); 

    }


}