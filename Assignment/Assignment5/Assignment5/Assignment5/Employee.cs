using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Employee
    {
       public int EmpId;
       public string EmpName;
       public float Salary;

        public Employee(int EmpTd,String EmpName,float Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }
    }
    class PartTimeEmployee : Employee
    {
        float Wages;

        public PartTimeEmployee(int EmpId, string EmpName, float Salary,float Wages) : base(EmpId, EmpName, Salary)
        {
            this.Wages = Wages;
        }

        public static void Main()
        {
            Console.WriteLine("Enter the Employee Id");
            int EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            string EmpName = Console.ReadLine();
            Console.WriteLine("Enter the Employee Salary");
            float Salary = float.Parse(Console.ReadLine());
           




            Console.WriteLine("Enter p/P for Part Time Employeer and f/Ffor Full time Emplayee");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'p' || ch == 'P')
            {
                Console.WriteLine("Enter the Employee Wages");
                float Wages = float.Parse(Console.ReadLine());
                PartTimeEmployee pt = new PartTimeEmployee(EmpId, EmpName, Salary, Wages);
                Console.WriteLine("Employee Id is : " + EmpId);
                Console.WriteLine("         Name is : " + EmpName);
                Console.WriteLine("         Salary is : " + Salary);
                Console.WriteLine("         Wages is : " + Wages);
            }
            else
            {
                Employee ep = new Employee(EmpId, EmpName, Salary);
                Console.WriteLine("Employee Id is : " + EmpId);
                Console.WriteLine("         Name is : " + EmpName);
                Console.WriteLine("         Salary is : " + Salary);
            }
            
            Console.ReadKey();
        }
    }
}
