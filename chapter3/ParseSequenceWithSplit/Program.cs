using System;

// ParseSequenceWithSplit -- Input a series of numbers seperated by commas 
// parse them into integers and output the sum.

namespace ParseSequenceWithSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input a sequence of numbers.
            Console.WriteLine("Enter a series of numbers seperated by commas: ");
            // Read a line of text
            string input = Console.ReadLine();
            Console.WriteLine();

            // Now convert the line into individual segments based upon either 
            // commas or spaces 
            char[] dividers = { ',', ' ' };
            string[] segments = input.Split(dividers);

            // Convert each segment into a number 
            int sum = 0;

            foreach(string s in segments)
            {
                // Skip any empty segments 
                if (s.Length > 0)
                {
                    // Skip strings that aren't numbers 
                    if (IsAllDigits(s))
                    {
                        // Convert the string into a 32-bit integer.
                        int num = 0;

                        if(Int32.TryParse(s, out num))
                        {
                            Console.WriteLine("Next number = {0}", num);

                            // Add this number into the sum
                            sum += num;
                        }
                        // If parse fails, move on to the next number.
                    }
                }
            }

            // Output the sum
            Console.WriteLine("Sum = {0}", sum);

            // Wait for tje user to acknowledge the results
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
