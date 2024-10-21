namespace CatComparator
{
    public class CatNameComparer : IComparer<Cat>
    {
        public int Compare(Cat? x, Cat? y)
        {
            int result = x.Name.CompareTo(y.Name);

            if (result == 0)
            {
                result = y.Color.CompareTo(x.Color);
            }

            return result;
        }
    }
}
