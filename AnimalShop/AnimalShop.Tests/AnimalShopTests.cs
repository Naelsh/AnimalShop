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
        [Fact]
        public void SellAnimal_EmptyString()
        {
            // Arrange
            Animal expected = null;
            AnimalShop animalShop = new AnimalShop();

            // Act
            Animal actual = animalShop.SellAnimal("");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
