using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace AnimalShop
{
    public class AnimalShop
    {
        public double Balance
        {
            get;
            set;
        }

        public List<Animal> SoldAnimals { get; private set; }

        public AnimalShop()
        {
            Balance = 0;
            SoldAnimals = new List<Animal>();
        }


        public Animal SellAnimal(string animalName)
        {
            Animal animalToSell;
            string checkString = animalName.GetProper();

            switch(checkString)
            {
                case nameof(Tyrannosaurus):
                    animalToSell = new Tyrannosaurus();
                    Console.WriteLine("You probably want to buy a few days worth of goats!");
                    break;
                case nameof(Stegosaurus):
                    animalToSell = new Stegosaurus();
                    break;
                case nameof(Pterodactyl):
                    animalToSell = new Pterodactyl();
                    break;
                case nameof(Goat):
                    animalToSell = new Goat();
                    break;
                default:
                    return null;
            }
            Balance += animalToSell.Cost;
            SoldAnimals.Add(animalToSell);
            return animalToSell;
        }

        //private string GetProper(string text)
        //{
        //    CultureInfo culture_info = Thread.CurrentThread.CurrentCulture;
        //    TextInfo text_info = culture_info.TextInfo;
        //    return text_info.ToTitleCase(text);
        //}

        public void PrintAnimals()
        {
            foreach(Animal animal in SoldAnimals)
            {
                Console.WriteLine("-----");
                Console.WriteLine(animal);
            }
            Console.WriteLine("-----");
        }
    }
}