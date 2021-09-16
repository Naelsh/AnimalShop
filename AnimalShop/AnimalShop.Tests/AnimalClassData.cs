using System.Collections;
using System.Collections.Generic;

namespace AnimalShop.Tests
{
    public class AnimalClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tyrannosaurus(),
                "Tyrannosaurus"
            };
            yield return new object[] {
                new Stegosaurus(),
                "Stegosaurus"
            };
            yield return new object[] {
                new Pterodactyl(),
                "Pterodactyl"
            };
            yield return new object[] {
                new Goat(),
                "Goat"
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
