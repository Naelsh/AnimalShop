﻿namespace AnimalShop
{
    public class Goat : Animal
    {
        public string FurColor { get; private set; }
        public float HornLength { get; private set; }
        public float BeardLength { get; private set; }

        public Goat(string furColor, float hornLength, float beardLength, int age, double weight, decimal cost) : base(age, weight, cost)
        {
            FurColor = furColor;
            HornLength = hornLength;
            BeardLength = beardLength;
        }

        public Goat() : this("Spotted grey", 25f, 8.5f, 2, 60, 124) {}

        public override string ToString()
        {
            return $"{nameof(Goat)}\n{base.ToString()}\nBeard Length: {BeardLength}cm\nFur Color: {FurColor}\nBe ware of the {HornLength}cm horns!";
        }

    }
}