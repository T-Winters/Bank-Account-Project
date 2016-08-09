using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    public class Checking_Account : Account
    {                      

        public Checking_Account(string name, string accountNumber) : base(name, accountNumber, "Checking")
        {
            this.balance = 10000;
        }
               
        public override void AccountBalance()
        {
            Console.Clear();
            Console.WriteLine("Checking Account Balance");
            Console.WriteLine("\n\n\t" + this.accountType + "\t" + this.accountNumber + "\t\t" + "$" + this.balance +"\n\n");
        }

        public override void Transaction()
        {
            base.Transaction();
            AccountBalance();                
        }

        public override void Exit()
        {
            base.Exit();
        }
    }


    public class Reserve_Account : Account
    {            
        public Reserve_Account(string name, string accountNumber) : base(name, accountNumber, "Reserve")
        {
            this.balance = 20000;
        }

        public override void AccountBalance()
        {
            Console.Clear();
            Console.WriteLine("Reserve Account Balance");
            Console.WriteLine("\n\n\t" + this.accountType + "\t\t" + this.accountNumber + "\t\t" + "$" + this.balance + "\n\n");
        }

        public override void Transaction()
        {
            base.Transaction();
            AccountBalance();
        }

        public override void Exit()
        {
            base.Exit();
        }
    }

    public class Savings_Account : Account
    {       
        public Savings_Account(string name, string accountNumber) : base(name, accountNumber, "Savings")
        {
            this.balance = 50000;
        }

        public override void AccountBalance()
        {
            Console.Clear();
            Console.WriteLine("Savings Account Balance");
            Console.WriteLine("\n\n\t" + this.accountType + "\t\t" + this.accountNumber + "\t\t" + "$" + this.balance + "\n\n");
        }

        public override void Transaction()
        {
            base.Transaction();
            AccountBalance();
        }

        public override void Exit()
        {
            base.Exit();
        }
    }
}



