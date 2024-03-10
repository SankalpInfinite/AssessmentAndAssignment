using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigement2
{
    class ProgramAssigement2
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Account no");
            int Account_no = Convert.ToInt32(Console.Read());
            Console.WriteLine("Enter the Account Holder Name");
            string Customer_name = Console.ReadLine();
            Console.WriteLine("Enter the Account Type");
            string Account_type = Console.ReadLine();
            Console.WriteLine("Enter the Account Balance");
            double balance = Console.Read();
            Console.WriteLine("Enter the Type of Transaction D for DEPOSITE and W for WITHDRAWL ");
            char Transaction = Convert.ToChar(Console.Read());
            Console.WriteLine("Enter the amount want to cerdit or debit");
            double Amount = Console.Read();
            AccountAssigement2 ac = new AccountAssigement2(Account_no, Customer_name, Account_type, balance);
            ac.Transaction_Type(Transaction, Amount);
            ac.show();
            Console.WriteLine("--------------------------------------------------------");

            StudentAssigement2 st = new StudentAssigement2(1234, "Kushal", 11, 2, "CSE");
            st.GetMarks(new int[] { 1, 2, 3, 4, 5 });
            st.DisplayResult();
            st.DisplayData();
            Console.WriteLine("-------------------------------------------------------------");

            SaledetailsAssigement2 sd = new SaledetailsAssigement2(1234, 8767, 66, 7, Convert.ToDateTime("05/05/2005"));
            sd.Sales();
            sd.show();
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("Enter the  Customer Name");
            int CustomerName = Convert.ToInt32(Console.Read());
            Console.WriteLine("Enter the Age");
            int Age = Convert.ToInt32(Console.Read());
            Console.WriteLine("Enter the Phone No");
            long Phoneno = Convert.ToInt64(Console.Read());
            Console.WriteLine("Enter the Name");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter the City");
           string City = Console.ReadLine();
            CustomerAssigement2 cs = new CustomerAssigement2(CustomerName, Age, Phoneno, Name,City);
            CustomerAssigement2.DisplayCustomer(CustomerName, Age, Phoneno, Name, City);


            Console.Read();
        }
    }
}
