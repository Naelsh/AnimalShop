namespace AnimalShop
{
    public class Stegosaurus : Animal
    {
        // We have the Get as public in order to let other parts of the program access the value.
        // But we hide the Set for the property since other parts of the program should not be able to change the skin color
        // It doesn't make sense for the color to change at other times
        public string SkinColor
        {
            get;
            private set;
        }

        public int BackplateCount
        {
            get;
            set;
        }

        public float TailspikeLength
        {
            get;
            set;
        }

        public Stegosaurus(string skinColor, int backplateCount, float tailSpikeLength, int age, double weight, float cost) : base(age, weight, cost)
        {
            SkinColor = skinColor;
            BackplateCount = backplateCount;
            TailspikeLength = tailSpikeLength;
        }

        public Stegosaurus() : this("Orange", 16, 30.5f, 1, 1500, 5000)
        {

        }

        public override string ToString()
        {
            return $"Stegosaurs\n{base.ToString()}\nBackplate Count: {BackplateCount}\nSkin Color: {SkinColor}\nBe ware of the {TailspikeLength}cm long tailspikes, of which there are four!";
        }
    }
}