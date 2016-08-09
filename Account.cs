using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
   
    public class Account
    {
        
        public string accountName;
        public string accountNumber;
        public string accountType;
        public double balance;
        public double deposit;
        public double withdraw;

        public string address = "124 Conch Street, Bikini Bottom";
        public string city = "Cleveland";
        public string state = "Ohio";
        public int zipCode = 90210;
        public string eMail = "ChalupaBatman@virtualbank.com";
        public string phoneNumber = "281-330-8004";
        //properties
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public int ZipCode
        {
            get { return this.zipCode; }
            set { this.zipCode = value; }
        }

        public string Email
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public double Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }
        }

        public Account(string accountName, string accountNumber, string accountType)
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
        }     
     
        public void MyInfo()
        {
            Console.Clear();
            Console.WriteLine("My Info");

            Console.WriteLine("\n\n" + accountNumber + "\n" +
                this.accountName + "\n" +
               this.address + "\n" +
                this.city + ", " + this.state + " " + this.zipCode + "\n" +
                this.eMail + "\n" +
                this.phoneNumber);

            Exit();
        }

        public virtual void Home()
        {          
            
        }

        public virtual void Exit()
        {
            {
                Console.WriteLine("\n[1] Home\n[2] Sign Out");

                int exit = 0;

                string exitChoice = Console.ReadLine();
                if (exitChoice == "1" || exitChoice == "2")
                {
                    exit = Convert.ToInt32(exitChoice);
                }

                if (exit == 1)
                {
                    Home();
                }
                else if (exit == 2)
                {
                    SignOut();                    
                }
                
            }
        }

        public void NotAnOption()
        {
            Console.WriteLine("Sorry, that is not an option." +
                                            "\nPress any key to continue, then select from options 1 - 5.");
            Console.ReadKey();
            Console.ReadLine();
        }

        public void SignOut()
        {
            Console.WriteLine("Are you sure you want to sign out?" +
                        "\n[1] Yes\n[2] No");
            int signOut = 0;
            string signOutChoice = Console.ReadLine();
            if (signOutChoice == "1" || signOutChoice == "2" || signOutChoice == "3" || signOutChoice == "4" || signOutChoice == "5")
            {
                signOut = Convert.ToInt32(signOutChoice);
            }
            if (signOut == 1)
            {
                Environment.Exit(0);

            }
            else if (signOut == 2)
            {
                Console.Clear();
                Home();
            }
            else
            {
                Console.WriteLine("\nSorry, that is not an option.");
                Console.WriteLine("\n[1] Yes\n[2] No");
                Console.ReadLine();
            }                       
        }

        public virtual void AccountBalance()
        {
            Console.Clear();
            Console.WriteLine("\n\n" + this.accountType + "\t" + this.accountNumber + "\t\t" + "$" + this.balance + "\n\n");
            Exit();
        }

        public virtual void Transaction()
        {
            Console.Clear();
            Console.WriteLine("Pick a type of transaction to be made.");
            Console.WriteLine("\n\n[1] Deposit\n[2] Withdraw");

            int transaction = int.Parse(Console.ReadLine());
            if (transaction == 1)
            {
                Console.WriteLine("Enter Deposit Amount: ");
                double depositAmount = Convert.ToDouble(Console.ReadLine());
                this.deposit = (depositAmount);
                this.balance += this.deposit;

                if (depositAmount < 1)
                {
                    Console.WriteLine("Deposits must be a minimum of $1 (one U.S. dollar).");
                    Console.WriteLine("\nPress any key to start a new transaction.");
                    Console.ReadKey();
                    Transaction();
                }
                else
                {
                    
                }
            }
            else if (transaction == 2)
            {
                Console.WriteLine("Enter Withdraw Amount?");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                this.withdraw = (withdrawAmount);
                this.balance -= this.withdraw;

                if (withdrawAmount < 1)
                {
                    Console.WriteLine("Withdrawls must be a minimum of $1 (one U.S. dollar)");
                    Console.WriteLine("\nPress any key to start a new transaction.");
                    Console.ReadKey();
                    Transaction();
                }
                else
                {
                    
                }
            }
            else
            {
                Console.WriteLine("Sorry, that is not an option." +
                    "Press any key to start a new transaction");
                Console.ReadKey();
                Transaction();
            }
            Console.WriteLine("\nYour transaction has been processed." +
                "\nPress any key to view your new account balance.");
            Console.ReadKey();
        }     
        
                       
        
    }
    
}




 
