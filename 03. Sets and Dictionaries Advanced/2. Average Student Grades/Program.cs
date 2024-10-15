using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                string inputLine = Console.ReadLine();

                string[] tokens = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string studentName = tokens[0];
                decimal grade = decimal.Parse(tokens[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                }

                students[studentName].Add(grade);
            }

            foreach (KeyValuePair<string, List<decimal>> kvp in students)
            {
                Console.Write($"{kvp.Key} -> ");

                decimal averageGrade = kvp.Value.Average();

                foreach (decimal grade in kvp.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {averageGrade:f2})");
            }
        }
    }
}
