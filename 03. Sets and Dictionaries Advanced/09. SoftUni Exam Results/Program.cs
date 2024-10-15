using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, int> usersPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();

            while (inputLine != "exam finished")
            {
                string[] tokens = inputLine.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];

                if (tokens[1] == "banned")
                {
                    if (usersPoints.ContainsKey(username))
                    {
                        usersPoints.Remove(username);
                        inputLine = Console.ReadLine();
                        continue;
                    }
                }

                string language = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!usersPoints.ContainsKey(username))
                {
                    usersPoints.Add(username, 0);
                }

                if (usersPoints[username] < points)
                {
                    usersPoints[username] = points;
                }

                if (!languageSubmissions.ContainsKey(language))
                {
                    languageSubmissions.Add(language, 0);
                }

                languageSubmissions[language]++;

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            usersPoints = usersPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, int> kvp in usersPoints)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            languageSubmissions = languageSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, int> kvp in languageSubmissions)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
