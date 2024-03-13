using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    interface IStudent
    {
        int StudentId { get; set; }
        void ShowDetails();
    }

    class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int grade { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Student is Day Scholar");
            Console.WriteLine("Student Id is: "+ StudentId);
            Console.WriteLine("Student Name is: "+StudentName);
            Console.WriteLine("Student Grade is: "+grade);
        }
    }
    class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int grade { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Student is Resident");
            Console.WriteLine("Student Id is: " + StudentId);
            Console.WriteLine("Student Name is: " + StudentName);
            Console.WriteLine("Student Grade is: " + grade);
        }
        class student
        {
            public static void Main()
            {
                Dayscholar ds = new Dayscholar();
                Console.WriteLine("Enter the StudentId");
                ds.StudentId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Student Name");
                ds.StudentName = Console.ReadLine();
                Console.WriteLine("Enter the Grade");
                ds.grade = int.Parse(Console.ReadLine());
                ds.ShowDetails();
                Console.WriteLine("----------------------------");
                Resident rs = new Resident();
                Console.WriteLine("Enter the StudentId");
                rs.StudentId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Student Name");
                rs.StudentName = Console.ReadLine();
                Console.WriteLine("Enter the Grade");
                rs.grade = int.Parse(Console.ReadLine());
                rs.ShowDetails();
                Console.ReadKey();
            }
        }
    }



}
