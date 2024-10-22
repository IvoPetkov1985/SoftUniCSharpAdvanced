using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] tokens = inputLine.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string personName = tokens.First();
                int personAge = int.Parse(tokens.Last());
                people.Add(new Person(personName, personAge));
            }

            string filterType = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string printFormat = Console.ReadLine();

            Func<Person, bool> filter = GetFilter(filterType, ageFilter);
            List<Person> selectedPeople = people.Where(filter).ToList();
            Action<Person> printer = GetPrinter(printFormat);

            foreach (Person person in selectedPeople)
            {
                printer(person);
            }

            Func<Person, bool> GetFilter(string filterType, int age)
            {
                switch (filterType)
                {
                    case "older": return p => p.Age >= age;
                    case "younger": return p => p.Age < age;
                    default: throw new ArgumentException(filterType);
                }
            }

            Action<Person> GetPrinter(string formatType)
            {
                switch (formatType)
                {
                    case "name age": return p => Console.WriteLine($"{p.Name} - {p.Age}");
                    case "name": return p => Console.WriteLine(p.Name);
                    case "age": return p => Console.WriteLine(p.Age);
                    default: return null;
                }
            }
        }

        class Person
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
