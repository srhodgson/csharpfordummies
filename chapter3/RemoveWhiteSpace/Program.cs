using System;

// RemoveWhiteSpace -- Remove any of a set of chars from a given string 
// use this method to remove whitespace from a sample string 
namespace RemoveWhiteSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the white spcae characters
            char[] whiteSpace = {' ', '\n', '\t'};

            // Start with a string that is embedded with whitespace 
            string s = " this is a\nstring"; // Constains spaces and a new line
            Console.WriteLine("before:" + s);

            // Output the string with the whitespace missing 
            Console.Write("after: ");

            // Start looking for the white space characters 
            for(;;)
            {
                // Find the offset of the character; exit the loop is there are more 
                int offset = s.IndexOfAny(whiteSpace);

                if (offset == -1)
                    break;
                
                // Break the string into the part prior to the character and the 
                // part after the character 
                string before = s.Substring(0, offset);
                string after = s.Substring(offset + 1);

                // Now put the two substrings back together with the character
                // in the middle missing.
                s = String.Concat(before, after);

                // Loop back up to find the next whitespace char in this modified 
                // s 
            }
            Console.WriteLine(s);

            // Wait for the user the acknowledge the results 
            Console.WriteLine("Press ENTER to terminate...");
            Console.Read();
        }
    }
}
