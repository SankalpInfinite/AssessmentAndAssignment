using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public delegate void Cal(int a, int b);
    class Calculator
    {
       public void Addition(int a,int b)
        {
            Console.WriteLine("Addition Result: "+(a+b));
        } 
       public void Subratction(int a,int b)
        {
            Console.WriteLine("Subratction Result: " + (a - b));
        }
        public void Multiplication(int a,int b)
        {
            Console.WriteLine("Multiplication Result: " + (a * b));
        }
        public static void Main()
        {
            Console.WriteLine("Enter the 1 Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2 Number");
            int b = Convert.ToInt32(Console.ReadLine());

            Calculator ca = new Calculator();
            Cal c1 = new Cal(ca.Addition);
            Cal c2 = new Cal(ca.Multiplication);
            Cal c3 = new Cal(ca.Subratction);
            c1(a, b);
            c2(a, b);
            c3(a, b);
            Console.ReadKey();
        }

    }
}
