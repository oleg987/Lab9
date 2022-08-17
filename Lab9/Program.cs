using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> words = new HashSet<string> 
            {
                "Hello",
                "World",
                "Student",
                "Subject",
                "Sea",
                "Fish"
            };

            // 1.

            Console.WriteLine(Contains(words, "Student"));
            Console.WriteLine(Contains(words, "Toy"));

            // 2.

            HashSet<int> numbers = new HashSet<int> { 5, 8, 7, 3, 4, 66, 95, 41 };

            numbers = numbers.OrderByDescending(x => x).ToHashSet();

            PrintFromIndex(numbers, 2);

            // 3.

            HashSet<Toy> toys = new HashSet<Toy>();

            toys.Add(new Toy("Barbie", 125.6m, 5));
            toys.Add(new Toy("Tractor", 100m, 5));
            toys.Add(new Toy("Lego", 225.6m, 5));
            toys.Add(new Toy("Race car", 125.6m, 5));
            toys.Add(new Toy("Airplane", 325.6m, 5));

            toys = toys.OrderBy(t => t.Title).ToHashSet();

            Print(toys);

            // 4.
            Console.WriteLine("----------------");
            toys = toys.OrderByDescending(t => t.Title).ToHashSet();

            // 5.
            Print(toys);

            // 6.
            Console.WriteLine("----------------");
            LettersCount("hello");

            // 7. 

            Dictionary<int, string> empty = new Dictionary<int, string>();

            KeyValuePair<int, string>[] array = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int, string>(1, "Hello"),
                new KeyValuePair<int, string>(2, "Toy"),
                new KeyValuePair<int, string>(3, "Sea")
            };

            Dictionary<int, string> values = new Dictionary<int, string>(array);

            // 8.

            values.Add(4, "qwerty");
            values.Add(5, "ytrewq");

            // 9.

            if (!values.ContainsKey(6))
            {
                values.Add(6, "qazwsx");
            }

            // 10.

            foreach (KeyValuePair<int, string> item in values)
            {
                Console.WriteLine($"Key: {item.Key}; Value: {item.Value};");
            }

        }

        private static void LettersCount(string word)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char item in word)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result.Add(item, 1);
                }
            }

            foreach (KeyValuePair<char, int> item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static void Print(HashSet<Toy> toys)
        {
            foreach (Toy item in toys)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintFromIndex(HashSet<int> numbers, int index)
        {
            int currentIndex = 0;

            foreach (int item in numbers)
            {
                if (currentIndex >= index)
                {
                    Console.WriteLine(item);
                }
                currentIndex++;
            }
        }

        static bool Contains(HashSet<string> set, string word)
        {
            foreach (string item in set)
            {
                if (item == word)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
