namespace AnimalShop
{
    public abstract class Animal
    {
        // Used protected for setting values since it should not be possible for functionality outside of the class to change the values.
        // The protected makes it private except for subclasses who can still inherit the and work with the values.
        // Get is still public since I see no problem with other parts of the program reading the data
        public int Age { get; protected set; }
        public double Weight { get; protected set; }
        public float Cost { get; protected set; }

        // I added multiple constructors here in order to be able to create generic animals with a set range of values.
        // these values are then sent to the other constructor in order to have one place to set the values in case we want
        // to change the logic later on
        public Animal() : this(0, 100, 10) {}

        public Animal(int age, double weight, float cost)
        {
            Age = age;
            Weight = weight;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Age: {Age}\nWeight: {Weight}kg\nCost: {Cost} Euro";
        }
    }
}