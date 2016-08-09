using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        //Properties


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


    /*    public void Home()
        {
            Console.Clear();
            Console.WriteLine("Welcome " + accountName + "!\n\n" +
                "[1] My Info\n" +
                "[2] View My Account Balance\n" +
                "[3] Deposit Funds\n" +
                "[4] Withdraw funds\n" +
                "[5] Sign Out\n");

            int homeOption = 0;

            string homeChoice = Console.ReadLine();
            if (homeChoice == "1" || homeChoice == "2" || homeChoice == "3" || homeChoice == "4" || homeChoice == "5")
            {
                homeOption = Convert.ToInt32(homeChoice);
            }

            if (homeOption == 1)
            {
                MyInfo();
            }
            else if (homeOption == 2)
            {
                MyAccountBalance();
            }
            else if (homeOption == 3)
            {
                DepositMenu();
            }
            else if (homeOption == 4)
            {
                WithdrawMenu();
            }
            else if (homeOption == 5)
            {
                Console.WriteLine("Are you sure you want to sign out?" +
                    "Press enter to sign out. If you do not wish to sign out, press any other key.");

                string exit = Console.ReadKey().Key.ToString();
                if (exit == "")
                {
                    Console.WriteLine(accountName + "signed out.");
                    Environment.Exit(0);
                }
                else
                {
                    Home();
                }

            }
            else
            {
                Console.WriteLine("Sorry, that is not an option." +
                                    "\nPress any key to continue, then select from options 1 - 5.");
                Console.ReadKey();
                Home();
            }
        }
     */
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

            Console.WriteLine("\n[1] Home" +
                "\n[2] Sign Out.");

            int returnHomeOption = 0;
            string returnHomeChoice = Console.ReadLine();
            if (returnHomeChoice == "1" || returnHomeChoice == "2")
            {
                returnHomeOption = Convert.ToInt32(returnHomeChoice);
            }

            if (returnHomeOption == 1)
            {
                //*******************************************Home();
            }
            else if (returnHomeOption == 2)
            {
                Console.WriteLine("Are you sure you want to sign out?" +
                    "Press enter to sign out. If you do not wish to sign out, press any other key.");

                string exit = Console.ReadKey().Key.ToString();
                if (exit == "")
                {
                    Console.WriteLine(accountName + "signed out.");
                    Environment.Exit(0);
                }
                else
                {
                    MyInfo();
                }
            }
            else
            {
                Console.WriteLine("Sorry, that is not an option." +
                    "\nPress any key to continue, then select from options 1 - 2.");
                Console.ReadKey();
                MyInfo();
            }
        }

        public void MyAccountBalance()
        {          
            Console.WriteLine("\n[1] Home" +
                "\n[2] Sign Out");

            int balanceOption = 0;

            Console.WriteLine("\n\n[1] Home\n[2] Sign Out");
            string balanceChoice = Console.ReadLine();
            if (balanceChoice == "1" || balanceChoice == "2")
            {
                balanceOption = Convert.ToInt32(balanceChoice);
            }

            if (balanceOption == 1)
            {
               //******************************************************Home();
            }
            else if (balanceOption == 2)
            {
                Console.WriteLine("Are you sure you want to sign out?" +
                    "Press enter to sign out. If you do not wish to sign out, press any other key.");

                string exit = Console.ReadKey().Key.ToString();
                if (exit == "")
                {
                    Console.WriteLine(accountName + "signed out.");
                    Environment.Exit(0);
                }
                else
                {
                    MyAccountBalance();
                }

            }
            else
            {
                Console.WriteLine("Sorry, that is not an option." +
                    "\nPress any key to continue, then select from options 1 - 2.");
                Console.ReadKey();
                MyAccountBalance();
            }
        }

        public void DepositMenu()
        {
            Console.Clear();

            Console.WriteLine("Which account would you like to make a deposit to?");
            Console.WriteLine("\n[1] Checking Account\n[2] Reserve Account\n[3] Savings Account\n\n[4] Home\n[5] Sign Out");
        }     
        
        public void WithdrawMenu()
        {
            Console.Clear();

            Console.WriteLine("Which account would you like to make a withdraw from?");
            Console.WriteLine("\n[1] Checking Account\n[2] Reserve Account\n[3] Savings Account\n\n[4] Home\n[5] Sign Out");
        }               
        
    }
    
}




 
