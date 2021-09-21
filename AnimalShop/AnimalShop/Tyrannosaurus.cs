namespace AnimalShop
{
    public class Tyrannosaurus : Animal
    {
        public int GoatsPerDay { get; private set; }
        public int TeethCount { get; private set; }
        public string SkinColor { get; private set; }

        public Tyrannosaurus(int goatsPerDay, int teethCount, string skinColor, int age, double weight, decimal cost) : base(age, weight, cost)
        {
            GoatsPerDay = goatsPerDay;
            TeethCount = teethCount;
            SkinColor = skinColor;
        }

        public Tyrannosaurus(int teethCount, string skinColor, int age, double weight, decimal cost)
            : this(AverageGoatsPerDay(age), teethCount, skinColor, age, weight, cost)
        {
        }

        public Tyrannosaurus() : this(4,60,"Green",1,4500,10000) { }

        public override string ToString()
        {
            return $"{nameof(Tyrannosaurus)}\n{base.ToString()}\nTeeth Count: {TeethCount}\nSkin Color: {SkinColor}\nFeed it {GoatsPerDay} goats per day";
        }

        // I hide this static method by using private in order to only let this class calculate this number. Other parts of the system only need to
        // know the amount the instance eats, not the average for the species
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