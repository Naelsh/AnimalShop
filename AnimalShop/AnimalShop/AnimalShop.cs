using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            switch(animalName.ToLower().Trim())
            {
                case "tyrannosaurus":
                    animalToSell = new Tyrannosaurus();
                    Console.WriteLine("You probably want to buy a few days worth of goats!");
                    break;
                case "stegosaurus":
                    animalToSell = new Stegosaurus();
                    break;
                case "pterodactyl":
                    animalToSell = new Pterodactyl();
                    break;
                case "goat":
                    animalToSell = new Goat();
                    break;
                default:
                    return null;
            }
            Balance += animalToSell.Cost;
            SoldAnimals.Add(animalToSell);
            return animalToSell;
        }

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