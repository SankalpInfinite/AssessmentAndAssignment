﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace AssessmentADO
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            SelectData();
            Proc();
            Console.ReadKey();
        }
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=ICS-LT-27M5893;initial catalog=Employeemanagement;integrated security=true");
            con.Open();
            return con;
        }
        public static void SelectData()
        {
            con = getConnection();
            cmd = new SqlCommand("select * from EmployeeDetails", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Employee Number : " + dr[0]);
                Console.WriteLine("Employee Name : " + dr[1]);
                Console.WriteLine("Employee Salary : " + dr[2]);
                Console.WriteLine("Employee Type : " + dr[3]);
            }
        }


        public static void Proc()
        {
            string EmpName;
            int EmpSalary;
            char EmpType;
            con = getConnection();
            Console.WriteLine("Enter the Name");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            EmpSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Type");
            EmpType = Convert.ToChar(Console.ReadLine());

            cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.Parameters.AddWithValue("@Empsal", EmpSalary);
            cmd.Parameters.AddWithValue("Emptype", EmpType);
  
            dr = cmd.ExecuteReader();
            SelectData();
        }

        

    }
}
