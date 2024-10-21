namespace CatComparator
{
    public class Cat
    {
        public Cat(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }

        public string Name { get; private set; }

        public string Color { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            return $"Name: {Name}, age: {Age} with color: {Color}";
        }
    }
}
