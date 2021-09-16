namespace AnimalShop
{
    public class Stegosaurus : Animal
    {
        public string SkinColor { get; private set; }
        public int BackplateCount { get; private set; }
        public float TailspikeLength { get; private set; }

        public Stegosaurus(string skinColor, int backplateCount, float tailSpikeLength, int age, double weight, float cost) : base(age, weight, cost)
        {
            SkinColor = skinColor;
            BackplateCount = backplateCount;
            TailspikeLength = tailSpikeLength;
        }

        public Stegosaurus() : this("Orange", 16, 30.5f, 1, 1500, 5000) {}

        public override string ToString()
        {
            return $"{nameof(Stegosaurus)}\n{base.ToString()}\nBackplate Count: {BackplateCount}\nSkin Color: {SkinColor}\nBe ware of the {TailspikeLength}cm long tailspikes, of which there are four!";
        }
    }
}