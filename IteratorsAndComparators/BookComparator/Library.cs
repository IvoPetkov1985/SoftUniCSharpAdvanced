using System.Collections;

namespace BookComparator
{
    public class Library : IEnumerable<Book>
    {
        private readonly SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books, new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryEnumerator(books.ToArray());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
