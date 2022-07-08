using System;
using System.Collections.Generic;

/**
 * PriorityQueue -- Demonstrates using lower-level queue collection
 * objects (generic ones at that) to implement a higher level geberic 
 * Queue that stores objects in priority order.
 */
namespace PriorityQueue
{
    internal class Program
    {
        // Main -- Fill the priority queue with packages, then 
        // remove a random number of them.
        static void Main(string[] args)
        {
            Console.WriteLine("Create a priority queue: ");
            PriorityQueue<Package> pq = new PriorityQueue<Package>();

            Console.WriteLine("Add a random number (0 - 20) of random packages to queue: ");
            Package pack;
            PackageFactory fact = new PackageFactory();

            // You want a random number less than 20
            Random rand = new Random();
            int numToCreate = rand.Next(20); // Random int from 0 - 20
            Console.WriteLine("\tCreating {0} packages: ", numToCreate);

            for (int i = 0; i < numToCreate; i++)
            {
                Console.WriteLine("\t\tGenerating and adding random package {0}", i);
                pack = fact.CreatePackage();
                Console.WriteLine(" with priority {0}", pack.Priority);
                pq.Enqueue;
            }

            Console.WriteLine("See what we got: ");
            int total = pq.Count;
            Console.WriteLine("Packages received: {0}", total);

            Console.WriteLine("Remove a random number of packages (0-20): ");
            int numToRemove = rand.Next(20);
            Console.WriteLine("\tRemoving up to {0} packages", numToCreate);

            for (int i = 0; i < numToRemove; i++)
            {
                pack pq.Dequeue();
                if (pack != null)
                {
                    Console.WriteLine("\t\tShipped package with priority {0}", pack.Priority);
                }
            }

            // See how many were "shipped"
            Console.WriteLine("Shipped {0} packages", total - pq.Count);

            // Wait for user to acknowledge the reults 
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }

    // Priority enumeration -- Defines a set of priorities 
    // instead of priorities like 1, 2, 3, ... these have names
    enum Priority
    {
        Low, Medium, High
    }

    // IPrioritizable interface -- Defines ability to prioritize
    // Define a custom interface: Classes that can be added to 
    // PriorityQueue must implement this interface.
    interface IPrioritizable
    {
        Priority Priority { get; } // Example of a property in an interface 
    }

    // PriorityQueue -- A generic priority queue class 
    // Types to add to the queue *must* implement IPrioritizable interface 
    class PriorityQueue<T> where T : IPrioritizable
    {
        // Queues -- the three underlying queues: all generic!
        private Queue<T> _queueHigh = new Queue<T>();
        private Queue<T> _queueMedium = new Queue<T>();
        private Queue<T> _queueLow = new Queue<T>();

        // Enqueue -- Prioritize T and add an item to type T to correct qeueue.
        // The item must know its own priority.
        public void Enqueue(T item)
        {
            switch(item.Priority) // Require IPriotiziable for this property
            {
                case Priority.High:
                    _queueHigh.Enqueue(item);
                    break;
                case Priority.Medium:
                    _queueMedium.Enqueue(item);
                    break;
                case Priority.Low:
                    _queueLow.Enqueue(item);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(item.Priority.ToString(), "bad priority in PriorityQueue.Enqueue");
            }
        }

        // Dequeue -- Get T from highest-priority queue available 
        public T Dequeue()
        {
            // Find the highest-priority queue with items.
            Queue<T> queueTop = TopQueue();
            // If a non-empty queue is found 
            if (queueTop != null & queueTop.Count > 0)
            {
                return queueTop.Dequeue(); // Return its front item
            }

            // If all queues empty, return null (you could throw an exception)
            return default(T);
        }

        // TopQueue -- What's the highest-priority underlying queue with the items?
        private Queue<T> TopQueue()
        {
            if (_queueHigh.Count > 0)
                return _queueHigh;

            if (_queueMedium.Count > 0)
                return _queueMedium;

            if (_queueLow.Count > 0)
                return _queueLow;

            return _queueLow;
        }
    }
}