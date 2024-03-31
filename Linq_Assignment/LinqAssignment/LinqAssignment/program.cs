using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
       


    }
    class program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>
            {
                 new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011,6,8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012,7,7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015,4,12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 06, 03), DOJ = new DateTime(2016,02,02), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 03, 08), DOJ = new DateTime(2016,02,02), City = "Munbai" },
                 new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 07), DOJ = new DateTime(2014,8,8), City = "Chennai" },
                  new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 02), DOJ = new DateTime(2015,06,1), City = "Mumbai" },
                   new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014,11,6), City = "Chennai" },
                    new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 08, 12), DOJ = new DateTime(2014,12,3), City = "Chennai" },
                     new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 04, 12), DOJ = new DateTime(2016,01,2), City = "Pune" }
            };

            //1.Display a list of all the employees who have joined before 1 / 1 / 2015
            var ans1 = emp.FindAll(e => e.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("Employees joined before 1/1/2015:");
            foreach (var e in ans1)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            //2.Display a list of all the employees whose date of birth is after 1/1/1990
            var ans2= emp.FindAll(e => e.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("Employees born after 1/1/1990:");
            foreach (var e in ans2)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            //3.Display a list of all the employees whose designation is “Consultant” and “Associate”
            var ans3 = emp.FindAll(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("Employees with designation 'Consultant' or 'Associate':");
            foreach (var e in ans3)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            //4.Display the total number of employees
            int ans4 = emp.Count;
            Console.WriteLine($"Total number of employees: {ans4}");
            Console.WriteLine("-----------------------------------------------------------------------------");
            //5.Display the total number of employees belonging to "Chennai"
            int ans5 = emp.Count(e => e.City == "Chennai");
            Console.WriteLine($"Total number of employees in Chennai: {ans5}");
            Console.WriteLine("-----------------------------------------------------------------------------");
            //6.Display the highest employee ID from the list
            int ans6 = emp.Max(e => e.EmployeeID);
            Console.WriteLine($"Highest employee ID: {ans6}");
            Console.WriteLine("-----------------------------------------------------------------------------");
            //7.Display the total number of employees who have joined after 1/1/2015
            int ans7 = emp.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"Total employees joined after 1/1/2015: {ans7}");
            Console.WriteLine("-----------------------------------------------------------------------------");
            //8.Display the total number of employees whose designation is not “Associate”
            int ans8 = emp.Count(e => e.Title != "Associate");
            Console.WriteLine($"Total non-Associate employees: {ans8}");
            Console.WriteLine("-----------------------------------------------------------------------------");
            //9.Display the total number of employees based on city
            var ans9 = emp.GroupBy(e => e.City);

            Console.WriteLine("Total employees by city:");
            foreach (var cgrp in ans9)
            {
                int cityEmployeeCount = cgrp.Count();
                Console.WriteLine($"{cgrp.Key}: {cityEmployeeCount}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            //10.Display the total number of employees based on city and title
            var ans10 = emp.GroupBy(e => new { e.City, e.Title });

            Console.WriteLine("Total employees by city and title:");
            foreach (var c_tgrp in ans10)
            {
                string city = c_tgrp.Key.City;
                string title = c_tgrp.Key.Title;
                int count = c_tgrp.Count();

                Console.WriteLine($"{city} ({title}): {count}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            //11.Display the total number of employees who are the youngest in the list
            var ans11 = emp.OrderBy(e => e.DOB).FirstOrDefault();
            Console.WriteLine($"Youngest employee: {ans11.FirstName} {ans11.LastName}");

            Console.ReadKey();

        }
    }
}
