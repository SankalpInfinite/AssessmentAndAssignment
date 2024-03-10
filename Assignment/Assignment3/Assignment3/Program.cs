using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment3_Program
    {
        string FirstName, LastName;
        
         static void Display(string FirstName, string LastName)
        {
            Console.WriteLine("First Name : "+FirstName.ToUpper());
            Console.WriteLine("Last Name : "+LastName.ToUpper());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name");
            String FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name");
            String LastNmae = Console.ReadLine();

            Assignment3_Program.Display(FirstName,LastNmae);
            Console.Read();
        }
    }
}
