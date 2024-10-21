using System.Collections;

namespace CatComparator
{
    public class CatEnumerator : IEnumerator<Cat>
    {
        private readonly IReadOnlyList<Cat> cats;
        private int index = -1;

        public CatEnumerator(params Cat[] cats)
        {
            this.cats = new List<Cat>(cats);
            Reset();
        }

        public Cat Current => cats[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index++;
            return index < cats.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
