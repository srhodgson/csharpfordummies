using System;

namespace BuildASentence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Each line you enter will be added to a sentence until you enter EXIT or QUIT.");

            // Ask the user for input; continue concatenating the phrases input until
            // the user enters exit or quit (start with an empty sentence).
            string sentence = "";

            for (; ; )
            {
                // Get the next line 
                Console.WriteLine("Enter a string ");
                string line = Console.ReadLine();

                // Exit the loop if the line is a terminator 
                bool quitting = false;

                if (String.Compare("exit", line, true) == 0 || String.Compare("quit", line, true) == 0 ) 
                    quitting = true;

                if (quitting == true)
                    break;
                
                // Otherwise, add it to the sentence 
                sentence = String.Concat(sentence, line);

                // Let the user know how they're doing 
                Console.WriteLine("\nyou've entered: " + sentence);
            }

            Console.WriteLine("\ntotal sentence:\n " + sentence);

            // Wait for the user to acknowledge the results 
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
