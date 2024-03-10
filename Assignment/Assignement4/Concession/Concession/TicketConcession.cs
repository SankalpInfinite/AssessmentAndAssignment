using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    {
        String Name;
        double Total_Fare;
        public TicketConcession(String Name,double Total_Fare)
        {
            this.Name = Name;
            this.Total_Fare = Total_Fare;
        }
        public void CalculateConcession(int age)
        {
            if(age <= 5)
                Console.WriteLine($"Little Champs {Name} of age {age} - Free Ticket");
            else if(age > 60)
            {
                double discount = .3 * Total_Fare;
                if(discount>500)
                    Console.WriteLine($"Ticket Booked for {Name} of age {age} get a discount of 500 Cause of Senior Citizen and Your Final Fare is {Total_Fare - 500}");
                else
                    Console.WriteLine($"Ticket Booked for {Name} of age {age} get a discount of 500 and Your Final Fare is {Total_Fare - discount}");
            }
            else
                Console.WriteLine($" Ticket Booked for {Name} of age {age}  Your Final Fare is {Total_Fare}");
        }
    }
}
