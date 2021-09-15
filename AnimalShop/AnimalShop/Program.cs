﻿using System;

namespace AnimalShop
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShop animalShop = new AnimalShop();
            Menu menu = new Menu();
            menu.ShowMenu();
            while(menu.HandleInput(Console.ReadLine(), animalShop))
            {
                Console.WriteLine($"You have purchased {animalShop.SoldAnimals.Count} animals so far.\nWith a total cost of {animalShop.Balance}");
            }
        }
    }
}
