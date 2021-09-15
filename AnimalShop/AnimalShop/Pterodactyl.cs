namespace AnimalShop
{
    public class Pterodactyl : Animal
    {
        public string FeatherColor { get; private set; }
        public float Wingspan { get; private set; }
        public float BeakLength { get; private set; }

        public Pterodactyl(string featherColor, float wingspan, float beakLength, int age, double weight, float cost) : base(age, weight, cost)
        {
            FeatherColor = featherColor;
            Wingspan = wingspan;
            BeakLength = beakLength;
        }

        public Pterodactyl() : this("Multicolor", 50f, 7.5f, 1, 150, 7000) {}

        public override string ToString()
        {
            return $"Pterodactyl\n{base.ToString()}\nWingspan: {Wingspan}cm\nFeather Color: {FeatherColor}\nBe ware of the {BeakLength}cm long beak riddled with teeth";
        }
    }
}