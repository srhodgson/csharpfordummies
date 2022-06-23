using System;

// CalculateInterestWithEmbeddedTest -- Calculate the interest amount paid on 
//    a given principal. If either the principal or the interest rate is 
//    negative, then generate an error message and don't proceed with the 
//    calculation.

namespace CalculateInterestWithEmbeddedTest
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

            // If the principal is negative ...
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
                    decimal interestPaid = principal * (interest / 100);

                    decimal total = principal + interestPaid;

                    Console.WriteLine();
                    Console.WriteLine("Principal        = " + principal);
                    Console.WriteLine("Interest         = " + interest + "%");
                    Console.WriteLine();
                    Console.WriteLine("Interest paid    = " + interestPaid);
                    Console.WriteLine("Total            = " + total);
                }
            }
            Console.WriteLine("Press ENTER to terminate...");
            Console.ReadLine();
        }
    }
}