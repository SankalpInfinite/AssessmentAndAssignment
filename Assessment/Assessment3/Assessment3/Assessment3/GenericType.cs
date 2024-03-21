using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class GenericType
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class Details
    {
        public static void Main()
        {
            List<GenericType> empList = new List<GenericType>
            {
                new GenericType { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new GenericType { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new GenericType { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza ", Title = "Consultant", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new GenericType { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new GenericType { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2014, 7, 7), City = "Mumbai" },
                new GenericType { EmployeeID = 1006, FirstName = "Amit", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1973, 8, 20), DOJ = new DateTime(2010, 7, 7), City = "Mumbai" },
                new GenericType { EmployeeID = 1007, FirstName = "Vijay", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1967, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new GenericType { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1977, 8, 20), DOJ = new DateTime(2010, 7, 7), City = "Mumbai" },
                new GenericType { EmployeeID = 1009, FirstName = "Suresh", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1989, 8, 20), DOJ = new DateTime(2010, 7, 7), City = "Mumbai" },
                new GenericType { EmployeeID = 1010, FirstName = "Sumit", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1979, 8, 20), DOJ = new DateTime(2010, 7, 7), City = "Mumbai" }
            }; Console.WriteLine("a. Details of all employees:");
            foreach (var emp in empList)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }

            Console.WriteLine(" Details of employees not in Mumbai:");
            var nonMumbaiEmployees = empList.Select(emp => emp.City != "Mumbai");
            foreach (var emp in nonMumbaiEmployees)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, City: {emp.City}");
            }

            Console.WriteLine("Details of employees with title 'AsstManager':");
            var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}");
            }

            Console.WriteLine("Details of employees whose last name starts with 'S':");
            var lastNameStartsWithS = empList.Where(emp => emp.LastName.StartsWith("S"));
            foreach (var emp in lastNameStartsWithS)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}");
            }
            Console.ReadKey();
        }
    }
}
