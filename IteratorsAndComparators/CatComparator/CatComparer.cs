namespace CatComparator
{
    public class CatComparer : IComparer<Cat>
    {
        public int Compare(Cat? x, Cat? y)
        {
            int result = x.Age.CompareTo(y.Age);

            return result;
        }
    }
}
