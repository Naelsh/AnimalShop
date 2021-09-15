using System;

namespace AnimalShop
{
    class Menu
    {
        public void ShowMenu()
        {
            Console.Clear();
            ShowHeader();
            ShowBody();
        }

        private void ShowBody()
        {
            Console.WriteLine("Welcome in!\nThe animals we have in stock are\nTyrannosaurus\nStegosaurus\nPterdoactyl\nGoats (mainly as food for the T-Rex)\n" +
                            "If you want to buy any animal, please enter the name of the animal and it will be purchased for you\n" +
                            "If you want to see the animals you have purchased, please write \"List\"\n"+
                            "If you want to exit the shop, write Q");
        }

        private void ShowHeader()
        {
            Console.WriteLine(
                @"$$$$$$$\  $$\                                 $$\    " + "\n" +
                @"$$  __$$\ \__ |                               $$ |" + "\n" +
                @"$$ |  $$ |$$\ $$$$$$$\   $$$$$$\   $$$$$$$\$$$$$$\   $$$$$$\   $$$$$$\   $$$$$$\  " + "\n" +
                @"$$ |  $$ |$$ |$$  __$$\ $$  __$$\ $$  _____\_$$  _ | $$  __$$\ $$  __$$\ $$  __$$\ " + "\n" +
                @"$$ |  $$ |$$ |$$ |  $$ |$$ /  $$ |\$$$$$$\   $$ |   $$ /  $$ |$$ |  \__ |$$$$$$$$ |" + "\n" +
                @"$$ |  $$ |$$ |$$ |  $$ |$$ |  $$ | \____$$\  $$ |$$\$$ |  $$ |$$ |      $$   ____ |" + "\n" +
                @"$$$$$$$  |$$ |$$ |  $$ |\$$$$$$  |$$$$$$$  | \$$$$  \$$$$$$  |$$ |      \$$$$$$$\ " + "\n" +
                @"\_______/ \__|\__|  \__| \______/ \_______/   \____/ \______/ \__|       \_______|" + "\n"
            );
        }

        public bool HandleInput(string input, AnimalShop animalShop)
        {
            ShowMenu();
            Console.WriteLine("");
            if(input.Length == 0)
            {
                Console.WriteLine("You haven't entered anything. Please try again");
                return true;
            }
            if(input.ToLower() == "list")
            {
                Console.WriteLine("The animals you have bought are:");
                animalShop.PrintAnimals();
                return true;
            }
            if(input.ToLower() == "q")
            {
                return false;
            }

            Animal animal = animalShop.SellAnimal(input);
            if(animal == null)
            {
                Console.WriteLine("The animal you are trying to purchase does not exist, check your spelling and try again");
            }
            else
            {
                Console.WriteLine("Congratulations you purchased: ");
                Console.WriteLine(animal);
            }
            return true;
        }
    }
}
