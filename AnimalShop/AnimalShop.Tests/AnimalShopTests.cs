using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AnimalShop.Tests
{
    public class AnimalShopTests
    {
        [Theory]
        [InlineData(null ,"")]
        public void SellAnimal_EmptyString(Animal expected, string animalName)
        {
            // Arrange
            AnimalShop animalShop = new AnimalShop();

            // Act
            Animal actual = animalShop.SellAnimal(animalName);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(AnimalClassData))]
        public void SellAnimal_AnimalString(Animal expected, string animalName)
        {
            // Arrange
            AnimalShop animalShop = new AnimalShop();

            // Act
            Animal actual = animalShop.SellAnimal(animalName);

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }
    }
}
