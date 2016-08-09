using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    public class Checking_Account : Account
    {
        protected double startingBalance;
        protected double newBalance;

        public Checking_Account(string name, string accountNumber) : base(name, accountNumber, "Checking")
        {
            this.startingBalance = 10000;
            this.newBalance = this.startingBalance + this.deposit - this.withdraw;
        }

        public void CheckingAccountBalance()
        {
            Console.WriteLine("\n\n" + this.accountType + "\t" + this.accountNumber + "\t\t" + "$" + this.newBalance);
        }

        public void DepositToChecking()
        {
            Console.Clear();
            Console.WriteLine("Deposit to Checking Account" +
                "\n" + this.accountType + "\t" + this.accountNumber + "\t\t" + "$" + this.newBalance);

            Console.WriteLine("Enter deposit amount: ");
                this.deposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your deposit has been received. Press Enter to view your balance.");
            Console.ReadKey();
            Console.Clear();
            CheckingAccountBalance();    
        }

        public void WithdrawFromChecking()
        {
            Console.Clear();
            Console.WriteLine("Withdraw from Checking Account" +
                "\n" + this.accountType + "\t" + this.accountNumber + "\t\t" + "$" + this.newBalance);

            Console.WriteLine("Enter withdraw amount: ");
            this.withdraw = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your withdraw has been received. Press Enter to view your balance.");
            Console.ReadKey();
            Console.Clear();
            CheckingAccountBalance();
        }
    }


    public class Reserve_Account : Account
    {
        protected double startingBalance;
        protected double newBalance;

        public Reserve_Account(string name, string accountNumber) : base(name, accountNumber, "Reserve")
        {
            this.startingBalance = 20000;
            this.newBalance = this.startingBalance + this.deposit - this.withdraw;
        }
                
        public void ReserveAccountBalance()
        {
            Console.WriteLine("\n\n" + this.accountType + "\t\t" + this.accountNumber + "\t\t" + "$" + this.newBalance);
        }

        public void DepositToReserve()
        {
            Console.Clear();
            Console.WriteLine("Deposit to Reserve Account" +
                "\n" + this.accountType + "\t\t" + this.accountNumber + "\t\t" + "$" + this.newBalance);

            Console.WriteLine("Enter deposit amount: ");
            this.deposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your deposit has been received. Press Enter to view your balance.");
            Console.ReadKey();
            Console.Clear();
            ReserveAccountBalance();
        }

        public void WithdrawFromReserve()
        {
            Console.Clear();
            Console.WriteLine("Withdraw from Reserve Account" +
                "\n" + this.accountType + "\t\t" + this.accountNumber + "\t\t" + "$" + this.newBalance);

            Console.WriteLine("Enter withdraw amount: ");
            this.withdraw = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your withdraw has been received. Press Enter to view your balance.");
            Console.ReadKey();
            Console.Clear();
            ReserveAccountBalance();
        }


    }

    public class Savings_Account : Account
    {
        protected double startingBalance;
        protected double newBalance;

        public Savings_Account(string name, string accountNumber) : base(name, accountNumber, "Savings")
        {
            this.startingBalance = 50000;
            this.newBalance = this.startingBalance + this.deposit - this.withdraw;
        }

        public void SavingsAccountBalance()
        {
            Console.WriteLine("\n\n" + this.accountType + "\t\t" + this.accountNumber + "\t\t" + "$" + this.newBalance);
        }

        public void DepositToSavings()
        {
            Console.Clear();
            Console.WriteLine("Deposit to Savings Account" +
                "\n" + this.accountType + "\t\t" + this.accountNumber + "\t\t" + "$" + this.newBalance);

            Console.WriteLine("Enter deposit amount: ");
            this.deposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your deposit has been received. Press Enter to view your balance.");
            Console.ReadKey();
            Console.Clear();
            SavingsAccountBalance();
        }

        public void WithdrawFromSavings()
        {
            Console.Clear();
            Console.WriteLine("Withdraw from Savings Account" +
                "\n" + this.accountType + "\t\t" + this.accountNumber + "\t\t" + "$" + this.newBalance);

            Console.WriteLine("Enter withdraw amount: ");
            this.withdraw = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your withdraw has been received. Press Enter to view your balance.");
            Console.ReadKey();
            Console.Clear();
            SavingsAccountBalance();
        }
    }
}



