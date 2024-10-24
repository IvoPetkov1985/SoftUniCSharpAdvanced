namespace EquilityScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int first = 10;
            int second = 20;

            Scale<int> scale = new Scale<int>(first, second);
            Console.WriteLine(scale.AreEqual());

            string student1 = "Dimi";
            string student2 = "Dimi";

            Scale<string> studentsScale = new Scale<string>(student1, student2);
            Console.WriteLine(studentsScale.AreEqual());
        }
    }
}
