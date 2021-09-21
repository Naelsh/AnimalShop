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
            Console.WriteLine($"\nWelcome in!\nThe animals we have in stock are\n- {nameof(Tyrannosaurus)}\n- {nameof(Stegosaurus)}\n- {nameof(Pterodactyl)}\n- {nameof(Goat)} (mainly as food for the T-Rex)\n" +
                            "\nPlease enter the name of the animal in order to buy it\n" +
                            "Write \"List\" to see animals you have bought\n" +
                            "If you want to exit the shop, write Q\n");
        }

        private void ShowHeader()
        {
            Console.WriteLine(
                @"$$$$$$$\  $$\                                $$\" + "\n" +
                @"$$  __$$\ \__ |                              $$ |" + "\n" +
                @"$$ |  $$ |$$\ $$$$$$$\   $$$$$$\   $$$$$$$\$$$$$$\   $$$$$$\   $$$$$$\   $$$$$$\" + "\n" +
                @"$$ |  $$ |$$ |$$  __$$\ $$  __$$\ $$  _____\_$$ _ | $$  __$$\ $$  __$$\ $$  __$$\" + "\n" +
                @"$$ |  $$ |$$ |$$ |  $$ |$$ /  $$ |\$$$$$$\   $$ |   $$ /  $$ |$$ |  \__|$$$$$$$$ |" + "\n" +
                @"$$ |  $$ |$$ |$$ |  $$ |$$ |  $$ | \____$$\  $$ |$$\$$ |  $$ |$$ |      $$  ____ |" + "\n" +
                @"$$$$$$$  |$$ |$$ |  $$ |\$$$$$$  |$$$$$$$  | \$$$$  \$$$$$$  |$$ |      \$$$$$$$\ " + "\n" +
                @"\_______/ \__|\__|  \__| \______/ \_______/   \____/ \______/ \__|       \_______|" + "\n"
            );
        }

        public bool HandleInput(string input, AnimalShop animalShop)
        {
            ShowMenu();
            Console.WriteLine(input + '\n');
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
                Console.WriteLine("Application terminated");
                return false;
            }

            TryPurchaseAnimal(input, animalShop);

            Console.WriteLine($"You have purchased {animalShop.SoldAnimals.Count} animals so far.\nWith a total cost of {animalShop.Balance}");
            Console.WriteLine("\nIf you want to purchase more animals, refer to the meny options at the top");
            return true;
        }

        private static void TryPurchaseAnimal(string input, AnimalShop animalShop)
        {
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
        }
    }
}
