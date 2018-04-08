namespace CSLangFeatures.CS6
{
    class Car
    {
        public string Make { get; }
        public Car(string make)
        {
            Make = make;
        }
        private void SetMake(string newMake)
        {
            //Prior to CS6:
            //Make = newMake;
        }
    }

}