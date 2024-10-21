namespace CatComparator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat("Funa", "Mixed", 11);
            Cat secondCat = new Cat("Maca", "Grey", 10);
            Cat thirdCat = new Cat("Melon", "Yellow", 1);
            Cat fourthCat = new Cat("Bijou", "Melange", 7);
            Cat fifthCat = new Cat("Maca", "White", 9);

            Cat[] catsInCatery = new Cat[] { firstCat, secondCat, thirdCat, fourthCat, fifthCat };

            Catery catery = new Catery(catsInCatery);

            foreach (Cat cat in catery)
            {
                Console.WriteLine(cat);
            }
        }
    }
}
