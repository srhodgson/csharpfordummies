using System;

// BubbleSortArray -- Given a list of planets, sort their names: first,
//    in alphabetical order. Second, by the length of their names, 
//    shortest length of their names, shortest to longest. Third, 
//    from longest to shortest. This demonstrates using and sorting arrays,
//    working with them by array index. Two sort algorithms are used :
//    1. The sort algorithm used by class Array's Sort() method.
//    2. The classic bubble Sort algorithm

namespace BubbleSortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The 5 planets closest to the sun, in order: ");

            string[] planets = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter" };

            foreach (string planet in planets)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nNow printed alphabetically: ");

            // Array.Sort() is a method on the Array class.
            // Array.Sort() does its work in-place in the planets array,
            // which leaves you without a copy of the original array. The
            // solution is to copy the old array to a new one and sort it.
            string[] sortedNames = planets;
            Array.Sort(sortedNames);

            // This demonstrates that (a) sortedNames contains the same 
            // strings as planets and (b) that they're now sorted
            foreach (string planet in sortedNames)
            {
                Console.WriteLine("\t"+planet);
            }

            Console.WriteLine("\nList by name length - shortest first: ");

            // This algorithm is called "Bubble Sort": It's the simplest 
            // but worst-performing sort. The Array.Sort() method is much
            // more efficient, but you can't use it directly to sort the 
            // planets in order of name length because it sorts strings 
            // not their lengths.
            int outer; // Index of outer loop
            int inner; // Index of inner loop

            // Loop DOWN from the last indec to the first: planets[4] to
            // planets [0]
            for (outer = planets.Length - 1; outer >= 0; outer--)
            {
                // On each other loop, loop through all elements BEYOND the 
                // current outer element. This loop goes up, from planets[1].
                // Using the for loop, you can traverse the array in either direction.
                for (inner = 1; inner <= outer; inner++)
                {
                    // Compare adjacent elements. If the earlier one is longer than the 
                    // later one, swap them. This shows how you can swap one array 
                    // element with another when they're out of order.
                    if (planets[inner - 1].Length > planets[inner].Length)
                    {
                        // Temporarily store one planet.
                        string temp = planets[inner -1];

                        // Now overwrite that planet with the other one.
                        planets[inner - 1] = planets[inner];

                        // Finally, reclaim the planet stored i ntemp and put it in
                        // place of the other.
                        planets[inner] = temp;
                    }
                }
            }

            foreach (string planet in planets)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nNow listed longest first: ");

            // That is, just loop down through the sorted planets 
            for (int i = planets.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t" + planets[i]);
            }

            Console.WriteLine("\nPress ENTER to terminate...");
            Console.Read();
        }
    }
}