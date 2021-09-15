﻿using System;
using System.Collections.Generic;

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
                Console.WriteLine($"You have purchased {animalShop.SoldAnimals.Count} so far.");
            }
        }
    }
}
