using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    
    class Program
    {        
        static void Main(string[] args)
        {
            Account account = new Account("Chalupa Batman", "8675309-00", "Main");
            Checking_Account checking_account = new Checking_Account("Chalupa Batman", "8675309-01");
            Reserve_Account reserve_account = new Reserve_Account("Chalupa Batman", "8675309-02");
            Savings_Account savings_account = new Savings_Account("Chalupa Batman", "8675309-03");


            while (true)
            {

                Console.Clear();
                Console.WriteLine("Welcome to Virtual Bank!\n\n" +
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
                    account.MyInfo();
                }
                else if (homeOption == 2)
                {                                    
                    Console.Clear();
                    checking_account.AccountBalance();
                    reserve_account.AccountBalance();
                    savings_account.AccountBalance();
                    Console.WriteLine("\n");
                    account.Exit();
                }
                else if (homeOption == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Select an account to deposit to \n\n");
                    Console.WriteLine("[1] Checking Account\n[2] Reserve Account\n[3] Savings Account\n[4] Home\n[5] Sign Out");

                    int depositOption = 0;
                    string depositChoice = Console.ReadLine();
                    if (depositChoice == "1" || depositChoice == "2" || depositChoice == "3" || depositChoice == "4" || depositChoice == "5")
                    {
                        depositOption = Convert.ToInt32(depositChoice);
                    }
                    if (depositOption == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Checking Account Transaction\n\n");
                        checking_account.Transaction();
                        checking_account.AccountBalance();
                    }
                    else if (depositOption == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Reserve Account Transaction\n\n");
                        reserve_account.Transaction();
                        reserve_account.AccountBalance();
                    }
                    else if (depositOption == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Savings Account Transaction\n\n");
                        savings_account.Transaction();
                        savings_account.AccountBalance();
                    }
                    else if (depositOption == 4)
                    {
                        account.Home();
                    }
                    else if (depositOption == 5)
                    {
                        account.SignOut();
                    }
                    
                    else
                    {
                        account.NotAnOption();
                    }
                }
                else if (homeOption == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Select an account to withdraw from: \n\n");
                    Console.WriteLine("[1] Checking Account\n[2] Reserve Account\n[3] Savings Account\n[4] Home\n[5] Sign Out");

                    int withdrawOption = 0;
                    string withdrawChoice = Console.ReadLine();
                    if (withdrawChoice == "1" || withdrawChoice == "2" || withdrawChoice == "3" || withdrawChoice == "4" || withdrawChoice == "5")
                    {
                        withdrawOption = Convert.ToInt32(withdrawChoice);
                    }

                    if (withdrawOption == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Checking Account Transaction\n\n");
                        checking_account.Transaction();
                        checking_account.AccountBalance();
                    }
                    else if (withdrawOption == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Reserve Account Transaction\n\n");
                        reserve_account.Transaction();
                        reserve_account.AccountBalance();
                    }
                    else if (withdrawOption == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Savings Account Transaction\n\n");
                        savings_account.Transaction();
                        savings_account.AccountBalance();
                    }
                    else if (withdrawOption == 4)
                    {
                        account.Home();
                    }
                    else if (withdrawOption == 5)
                    {
                        account.SignOut();
                    }
                    else
                    {
                        account.NotAnOption();
                    }
                }
                else if (homeOption == 5)
                {
                    account.SignOut();

                }
                else
                {
                    account.NotAnOption();
                }                             
            }            
        }
    }
}
    

