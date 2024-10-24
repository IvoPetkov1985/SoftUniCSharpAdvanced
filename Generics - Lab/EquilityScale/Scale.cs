namespace EquilityScale
{
    public class Scale<T>
    {
        private readonly T left;
        private readonly T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            bool result = left.Equals(right);
            return result;
        }
    }
}
