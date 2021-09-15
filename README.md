# AnimalShop
Betygsgrundande inlämningsuppgift

Answer the following questions as a comment in your code.
1. When should you use private instead of public?
2. When is it useful to have multiple constructor functions?

Your exercise for this week is to build a simple program with a class hierarchy. Imagine a pet shop, that sells different kinds of animals.

Create a class named AnimalShop that represents the pet shop.

Features:

- Create one class for each animal (at least three) that the shop can sell.
- Each animal class should have at least three properties.
- Also create a class Animal that contains whatever properties all animals have  
  in common. For example, each animal needs a price.
- Make sure that each specific animal class inherits from Animal.
- AnimalShop should have a method "public Animal SellAnimal(string animalType)" that returns an animal of the specified type.
If there is no such animal, for example if the user asks for a "crocodile" but you don't have a class Crocodile, it should return null.
- When an animal is sold, the AnimalShop object should gain money.
- Store the money in a property.
- Finally write a program that tests your classes (Menu).
  - It should create an object of the class AnimalShop.
  - Then buy some animals and print the values of all their properties.

Betygskriterier:

För G:

Alla ovanstående features ska vara implementerade.
