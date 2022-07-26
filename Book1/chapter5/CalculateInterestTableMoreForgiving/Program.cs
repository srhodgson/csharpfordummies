using System;

// CalculateInterestTableMoreForgiving -- Calculate the interest paid on a 
//    given principal over a period of years. This version gives the user 
//    multiple chances to input the legal principal and interest 

namespace CalculateInterestTableMoreForgiving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximumInterest = 50;

            decimal principal;
            
            while (true)
            {
                Console.Write("Enter principal: ");
                string principalInput = Console.ReadLine();
                principal = Convert.ToDecimal(principalInput);

                if (principal > 0)
                    break;

                Console.WriteLine("Principal cannot be negative");
                Console.WriteLine("Try again");
                Console.WriteLine();
            }

            decimal interest;

            while (true)
            {
                Console.Write("Enter interest: ");
                string interestInput = Console.ReadLine();
                interest = Convert.ToDecimal(interestInput);

                if (interest >= 0 && interest <= maximumInterest)
                    break;
                
                Console.WriteLine("Interest cannot be negative, or greater than " + maximumInterest);
                Console.WriteLine("Try again");
                Console.WriteLine();
            }

            Console.Write("Enter number of years: ");
            string durationInput = Console.ReadLine();
            int duration = Convert.ToInt32(durationInput);

            Console.WriteLine();
            Console.WriteLine("Principal = " + principal);
            Console.WriteLine("Interest  = " + interest +  "%");
            Console.WriteLine("Duration  = " + duration + " years ");
            Console.WriteLine();

            int year = 1;

            while (year <= duration)
            {
                decimal interestPaid;
                interestPaid = principal * (interest / 100);

                principal = decimal.Round(principal, 2);

                Console.WriteLine(year + " - " + principal);

                year = year + 1;
            }

            Console.WriteLine("Press ENTER to terminate...");
            Console.Read();
        }
    }
}