using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShop
{
    public class Pterodactyl : Animal
    {
        public string FeatherColor
        {
            get;
            private set;
        }

        public float Wingspan
        {
            get;
            set;
        }

        public float BeakLength
        {
            get;
            set;
        }

        public Pterodactyl(string featherColor, float wingspan, float beakLength, int age, double weight, float cost) : base(age, weight, cost)
        {
            FeatherColor = featherColor;
            Wingspan = wingspan;
            BeakLength = beakLength;
        }

        public Pterodactyl() : this("Multicolor", 50f, 7.5f, 1, 150, 7000)
        {

        }

        public override string ToString()
        {
            return $"Pterodactyl\n{base.ToString()}\nWingspan: {Wingspan}\nFeather Color: {FeatherColor}\nBe ware of the {BeakLength} long beak riddled with teeth";
        }
    }
}