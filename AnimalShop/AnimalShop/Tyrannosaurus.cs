﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShop
{
    public class Tyrannosaurus : Animal
    {
        public int GoatsPerDay
        {
            get;
            set;
        }

        public int TeethCount
        {
            get;
            set;
        }

        public string SkinColor
        {
            get;
            set;
        }

        public Tyrannosaurus(int goatsPerDay, int teethCount, string skinColor, int age, double weight, float cost) : base(age, weight, cost)
        {
            GoatsPerDay = goatsPerDay;
            TeethCount = teethCount;
            SkinColor = skinColor;
        }

        // You can use different constructors in order to set values based on different criterias.
        // In this case I base the feeding requirement based on the age and then using the above constructor to set the values
        public Tyrannosaurus(int teethCount, string skinColor, int age, double weight, float cost)
            : this(AverageGoatsPerDay(age), teethCount, skinColor, age, weight, cost)
        {

        }

        public Tyrannosaurus() : this(4,60,"Green",1,4500,10000)
        {

        }

        private static int AverageGoatsPerDay(int age)
        {
            switch(age)
            {
                case 1:
                    return 4;
                case 2:
                    return 5;
                case 3:
                    return 6;
                default:
                    return 10;
            }
        }
    }
}