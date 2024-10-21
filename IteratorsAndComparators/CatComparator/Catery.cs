using System.Collections;

namespace CatComparator
{
    public class Catery : IEnumerable<Cat>
    {
        private readonly SortedSet<Cat> cats;

        public Catery(params Cat[] cats)
        {
            this.cats = new SortedSet<Cat>(cats, new CatNameComparer());
        }

        public IEnumerator<Cat> GetEnumerator()
        {
            //foreach (Cat cat in cats)
            //{
            //    yield return cat;
            //}

            return new CatEnumerator(cats.ToArray());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
