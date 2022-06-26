using System;

// VariableArrayAverage -- Average an array whose size is determined 
//    by the user at runtime, accumulating the values in an array.
//    Allows them to be referenced as often as desired. In this case 
//    the array creates an attractive output.

namespace VariableArrayAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First read in the number of doubles the user intends to enter.
            Console.Write("Enter the number of values to average: ");
            string numElementsInput = Console.ReadLine();
            int numElements = Convert.ToInt32(numElementsInput);
            Console.WriteLine();

            // Now declare an array of that size 
            double[] doublesArray = new double[numElements];

            // Accumulates the values into an array
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine("Enter double #" + (i + 1) + ": ");
                string val = Console.ReadLine();
                double value = Convert.ToDouble(val);
                doublesArray[i] = value;
            }

            double sum = 0;
            for (int i = 0; i < numElements; i++)
            {
                sum = sum + doublesArray[i];
            }

            double average = sum / numElements;

            Console.WriteLine();
            Console.Write(average + " is the average of (" + doublesArray[0]);

            for (int i = 0; i < numElements; i++)
            {
                Console.Write(" + " + doublesArray[i]);
            }
            Console.WriteLine(") / " + numElements);

            Console.WriteLine("Press ENTER to terminate...");
            Console.Read();
        }
    }
}