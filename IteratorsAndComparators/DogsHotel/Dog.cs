namespace DogsHotel
{
    public class Dog : IComparable<Dog>
    {
        public Dog(string name, string color, int age, params string[] owners)
        {
            Name = name;
            Color = color;
            Age = age;
            OwnerNames = new List<string>(owners);
        }

        public string Name { get; private set; }

        public string Color { get; private set; }

        public int Age { get; private set; }

        public IReadOnlyList<string> OwnerNames { get; private set; }

        public int CompareTo(Dog? other)
        {
            int result = this.Age.CompareTo(other.Age);

            if (result == 0)
            {
                result = other.Name.CompareTo(this.Name);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} - {Color}";
        }
    }
}
