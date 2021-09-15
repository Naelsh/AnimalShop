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
            get => default;
            set
            {
            }
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
                    animalToSell = null;
                    break;
            }
            Balance += animalToSell.Cost;
            return animalToSell;
        }
    }
}