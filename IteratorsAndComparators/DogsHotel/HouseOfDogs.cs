using System.Collections;

namespace DogsHotel
{
    public class HouseOfDogs : IEnumerable<Dog>
    {
        private readonly SortedSet<Dog> dogs;

        public HouseOfDogs(params Dog[] dogs)
        {
            this.dogs = new SortedSet<Dog>(dogs);
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            foreach (Dog dog in dogs)
            {
                yield return dog;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
