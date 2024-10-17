using System.Collections;

namespace IteratorsAndComparators
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;

        private int currentIndex = -1;

        public LibraryIterator(params Book[] books)
        {
            this.books = books.ToList();
            this.Reset();
        }

        public Book Current => books[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < books.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
