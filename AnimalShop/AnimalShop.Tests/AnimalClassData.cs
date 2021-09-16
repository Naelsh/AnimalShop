using System.Collections;
using System.Collections.Generic;

namespace AnimalShop.Tests
{
    public class AnimalClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tyrannosaurus()
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
