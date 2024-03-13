using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigement2
{
    class AccountAssigement2
    {
        int Account_no;
        string Customer_name;
        string Account_type;
        double balance;

       public AccountAssigement2(int Account_no,string Customer_name,string Account_type,double balance)
        {
            this.Account_no = Account_no;
            this.Customer_name = Customer_name;
            this.Account_type = Account_type;
            this.balance = balance;
        }
        public void Transaction_Type(char Transaction_type, double amount)
        {
            if (Transaction_type=='D')
            {
                balance += amount;
            }
            else if (Transaction_type=='W')
            {
                balance -= amount;
            }else
                {
                Console.WriteLine("Enter amount and D for Deposite or W for Withdrawal");
            }
        }
        public void show()
        {
            Console.WriteLine($"Name of Coustmer : {Customer_name}");
            Console.WriteLine($"Account No of Coustmer : {Account_no}");
            Console.WriteLine($"Account Type of Coustmer : {Account_type}");
            Console.WriteLine($"Account Final Balance of Coustmer : {balance}");
        }
        public static void main()
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
            Console.Read();
        }
    }
}
