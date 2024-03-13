using System;
using Concession;

namespace TestConcession
{
    class Program
    {
        static void Main(string[] args)
        {
            double Total_Fare;
            Console.WriteLine("Enter the Age");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            string Name = Console.ReadLine();
            if (Age > 5)
            {
                Console.WriteLine("Enter your Fare");
                Total_Fare = double.Parse(Console.ReadLine());
            }
            else
                Total_Fare = 0;
            TicketConcession tc = new TicketConcession(Name, Total_Fare);
            tc.CalculateConcession(Age);
            Console.ReadKey();
        }
    }
}
