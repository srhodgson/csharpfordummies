using System;

// IsAllDigits -- Demonstrate the IsAllDigits method.

namespace IsAllDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input a string from the keyboard 
            Console.WriteLine("Enter an integer numer.");
            string s = Console.ReadLine();

            // First check to see if this could be a number 
            if (!IsAllDigits(s)) // Call the special method 
            {
                Console.WriteLine("Hey! That isn't a number");
            }
            else
            {
                // COnvert the string into an integer 
                int n = Int32.Parse(s);

                // Now write out the number times 2
                Console.WriteLine("2 * " + n + " = " + (2 * n));
            }

            // Wait for the user to acknowledge the results 
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        // IsAllDigits - Return true if all characters i nthe string are digits 
        public static bool IsAllDigits(string raw)
        {
            // First get rid fo any benign characters at either end;
            // if there is nothing left, you don't have a number 
            string s = raw.Trim(); // Ignore whitespace on either side 

            if (s.Length == 0)
                return false;

            // Loop through the string.
            for (int index = 0; index < s.Length; index++)
            {
                // A nondigit indicates that the strign probably isn't a number 
                if (Char.IsDigit(s[index]) == false)
                    return false;
            }

            // No non-digits found; it's probably okay
            return true;
        }
    }
}
