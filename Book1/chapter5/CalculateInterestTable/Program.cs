using System;

// CalculateInterestTable -- Calculate the interest paid on a given principal over a 
//    period of years.

namespace CalculateInterestTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a maximum interest rate
            int maximumInterest = 50;

            // Prompt user to enter source principal 
            Console.Write("Enter principal: ");
            string principalInput = Console.ReadLine();
            decimal principal = Convert.ToDecimal(principalInput);

            if (principal < 0)
            {
                Console.WriteLine("Principal cannot be negative");
            }
            else
            {
                Console.Write("Enter interest: ");
                string interestInput = Console.ReadLine();
                decimal interest = Convert.ToDecimal(interestInput);

                if (interest < 0 || interest > maximumInterest)
                {
                    Console.WriteLine("Interest cannot be negative or greater than " + maximumInterest);
                    interest = 0;
                }
                else
                {
                    Console.Write("Enter number of years: ");
                    string durationInput = Console.ReadLine();
                    int duration = Convert.ToInt32(durationInput);

                    Console.WriteLine();
                    Console.WriteLine("Principal = " + principal);
                    Console.WriteLine("Interest = " + interest);
                    Console.WriteLine("Duration = " + duration + " years");
                    Console.WriteLine();

                    int year = 1;

                    while (year <= duration)
                    {
                        decimal interestPaid;
                        interestPaid = principal * (interest / 100);

                        principal = principal + interestPaid;

                        principal = decimal.Round(principal, 2);

                        Console.WriteLine(year + " - " + principal);

                        year = year + 1;
                    }
                }
            }

            Console.WriteLine("\nPress ENTER to terminate...");
            Console.Read();
        }
    }
}