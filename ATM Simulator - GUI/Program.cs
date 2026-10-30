using System.Security.Principal;

namespace ATM_Simulator___GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static Account[] accounts = new Account[4];
        public static int selectedIndex = -1;
        [STAThread]

        static void CreateAccounts()
        {

            // Instantiate Accounts
            accounts[0] = new Account(0.00, "9999", "MasterAccount", "InsecureMasterPass"); // This account is able to view all accounts' data
            accounts[1] = new Account(4000.00, "0001", "DaveWilshire", "MyPass1234!");
            accounts[2] = new Account(5340.23, "0002", "EricH382", "Password123");
            accounts[3] = new Account(15032.85, "0003", "HankL", "pAss123");

            // Create Past Transactions 
            accounts[1].setTransaction("Deposit", 40.81);       // I didn't create transactions for the master account
            accounts[1].setTransaction("Deposit", 102.00);      // because it's meant to be more of an administrative tool,
            accounts[1].setTransaction("Withdrawal", 100.00);   // not an active account. This is why it has a balance of $0.00 by default as well.
            accounts[2].setTransaction("Withdrawal", 90.00);    // Nonetheless, money can still be deposited to it and transactions can still be
            accounts[2].setTransaction("Withdrawal", 15.00);    // recorded during the course of the program.
            accounts[2].setTransaction("Withdrawal", 50.00);
            accounts[3].setTransaction("Deposit", 250.00);
            accounts[3].setTransaction("Withdrawal", 80.00);
            accounts[3].setTransaction("Deposit", 105.00);
        }


        static void Main()
        {
            CreateAccounts();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}