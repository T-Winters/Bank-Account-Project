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
            Account account = new Account("Chalupa Batman", "8765309-00", "Main");
            Checking_Account checking_account = new Checking_Account("Chalupa Batman", "8765309-01");
            Reserve_Account reserve_account = new Reserve_Account("Chalupa Batman", "8765309-02");
            Savings_Account savings_account = new Savings_Account("Chalupa Batman", "8765309-03");




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
                checking_account.CheckingAccountBalance();
                reserve_account.ReserveAccountBalance();
                savings_account.SavingsAccountBalance();
                account.MyAccountBalance();
            }
            else if (homeOption == 3)
            {
                account.DepositMenu();
                int depositOption = 0;
                string depositChoice = Console.ReadLine();
                if (depositChoice == "1" || depositChoice == "2" || depositChoice == "3" || depositChoice == "4" || depositChoice == "5")
                {
                    depositOption = Convert.ToInt32(depositChoice);
                }
                if (depositOption == 1)
                {
                    checking_account.DepositToChecking();
                    account.MyAccountBalance();
                }
                else if (depositOption == 2)
                {
                    reserve_account.DepositToReserve();
                    account.MyAccountBalance();
                }
                else if (depositOption == 3)
                {
                    savings_account.DepositToSavings();
                    account.MyAccountBalance();
                }
                else if (depositOption == 4)
                {
                    Home();
                }
                else if (depositOption == 5)
                {
                    Console.WriteLine("Are you sure you want to sign out?" +
                        "Press enter to sign out. If you do not wish to sign out, press any other key.");

                    string exit = Console.ReadKey().Key.ToString();
                    if (exit == "")
                    {
                        Console.WriteLine("You successfully signed out.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        account.DepositMenu();
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
            else if (homeOption == 4)
            {
                account.WithdrawMenu();
                int withdrawOption = 0;
                string withdrawChoice = Console.ReadLine();
                if (withdrawChoice == "1" || withdrawChoice == "2" || withdrawChoice == "3" || withdrawChoice == "4" || withdrawChoice == "5")
                {
                    withdrawOption = Convert.ToInt32(withdrawChoice);
                }

                if (withdrawOption == 1)
                {
                    checking_account.WithdrawFromChecking();
                    account.MyAccountBalance();
                }
                else if (withdrawOption == 2)
                {
                    reserve_account.WithdrawFromReserve();
                    account.MyAccountBalance(); ;
                }
                else if (withdrawOption == 3)
                {
                    savings_account.WithdrawFromSavings();
                    account.MyAccountBalance();
                }
                else if (withdrawOption == 4)
                {
                    Home();
                }
                else if (withdrawOption == 5)
                {
                    Console.WriteLine("Are you sure you want to sign out?" +
                        "Press enter to sign out. If you do not wish to sign out, press any other key.");

                    string exit = Console.ReadKey().Key.ToString();
                    if (exit == "")
                    {
                        Console.WriteLine("You have successfully signed out.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        account.WithdrawMenu();
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
            else if (homeOption == 5)
            {
                Console.WriteLine("Are you sure you want to sign out?" +
                    "Press enter to sign out. If you do not wish to sign out, press any other key.");

                string exit = Console.ReadKey().Key.ToString();
                if (exit == "")
                {
                    Console.WriteLine(account.AccountName + " signed out.");
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
    }
}
    

