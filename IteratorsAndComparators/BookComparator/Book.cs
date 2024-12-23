﻿namespace BookComparator
{
    public class Book
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public string Title { get; private set; }

        public int Year { get; private set; }

        public IReadOnlyList<string> Authors { get; private set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
