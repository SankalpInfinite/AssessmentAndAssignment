using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigement2
{
  class CustomerAssigement2
    {
        public int CustomerId, Age;
        public long Phone;
        public string Name, City;
          CustomerAssigement2() {  }
        public CustomerAssigement2(int CustomerId, int Age, long Phone, string Name, string City)
        {
           this.CustomerId = CustomerId;
           this. Age = Age;
            this.Phone = Phone;
            this.Name = Name;
            this.City = City;
        }
        public static void DisplayCustomer(int CustomerId, int Age, long Phone, string Name, string City)
        {
            Console.WriteLine($"CustomerId of Customer: {CustomerId}");
            Console.WriteLine($"Age of Customer: {Age}");
            Console.WriteLine($"Phone No of Customer: {Phone}");
            Console.WriteLine($"Name of Customer: {Name}");
            Console.WriteLine($"City of Customer: {City}");
        }
        ~CustomerAssigement2()
        {
            Console.WriteLine("clear all");
        }
        
    }
}
