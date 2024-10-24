namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<int> ints = new CustomStack<int>();

            ints.AddElement(10);
            ints.AddElement(20);
            ints.AddElement(30);
            ints.AddElement(40);

            Console.WriteLine(ints.RemoveTopElement());
            Console.WriteLine(ints.GetPeekElement());
            Console.WriteLine(string.Join(" ", ints));

            CustomStack<string> strings = new CustomStack<string>();

            strings.AddElement("Mitko");
            strings.AddElement("Ani");
            strings.AddElement("Stefan");

            Console.WriteLine(string.Join(", ", strings.OrderBy(x => x)));
        }
    }
}
