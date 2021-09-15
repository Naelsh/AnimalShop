using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShop
{
    public class Animal
    {
        // Used protected for Age since it should not be possible to set the Age to any value.
        // The animal will slowly get older and if we want to change the Age a method for ageing should be implemented
        public int Age
        {
            get;
            protected set;
        }

        public double Weight
        {
            get;
            set;
        }

        public float Cost
        {
            get;
            set;
        }

        // I added multiple constructors here in order to be able to create generic animals and thus povide a set of values
        // these values are then sent to the other constructor in order to have one place to set the values in case we want
        // to change the logic later on
        public Animal() : this(0, 100, 10)
        {
        }

        public Animal(int age, double weight, float cost)
        {
            Age = age;
            Weight = weight;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Age: {Age}\nWeight: {Weight}\nCost: {Cost}";
        }
    }
}