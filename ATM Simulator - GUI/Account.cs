/* File: Account.cs
 * Date: 12/4/2024
 * Name: Kevin Viren
 * 
 * Description: Account class represents a bank account, featuring various appropriate properties such as a balance and account number. It also includes appropriate methods.
 */
using static System.Console;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

public class Account
{
    public const int MIN_LETTER_COUNT = 4;
    private double balance;
    private string acctNum;
    private string user;
    private string pass;
    private string[] transactions = new string[50];

    public double Balance { get; set; }
    public string AcctNum { get; }
    public string User { get; }
    public string Pass { get; }
    
    public Account(double bal, string accountNum, string username, string password)
    {
        if(accountNum.Length == 4)
        {
            AcctNum = accountNum;
        }
        else
        {
            AcctNum = "0000";
        }


        if(username.Length > 0 && username.Length < 32)
        {
            int i = 0;
            foreach(char c in username)
            {
                if(char.IsLetter(c)) 
                {
                    i += 1;
                }
            }

            if(i >= MIN_LETTER_COUNT) // Username must include minumum letter count (can't be all numbers or other symbols)
            {
                User = username;
            }
            else
            {
                User = "default";
            }
        }
        else
        {
            User = "default";
        }

        if(username.Length > 0 && username.Length < 45)
        {
            Pass = password; // I understand a password would normally be hashed,
        }                    //  not stored in plain text in the real world
        else
        {
            Pass = "default";
        }

        if(!AcctNum.Equals("0000") && !User.Equals("default") && !Pass.Equals("default"))
        {
            Balance = bal;
        }
        else
        {
            Balance = 0;
        }
    }


    // METHODS 

    public bool Deposit(double amount)
    {
        if(amount > 0) // Can't deposit 0 or negative money 
        {
            this.Balance += amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= this.Balance) // Can't withdraw negative money or withdraw more than balance sum
        {
            this.Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void setTransaction(string type, double amount)
    {
        for(int i = 0; i < transactions.Length; ++i)
        {
            if(transactions[i] == null)
            {
                //this.transactions[i] = type + " | " + amount.ToString("C");
                this.transactions[i] = $"{type, -10} | {amount.ToString("C")}";
                break;
            }
        }
    }

    public string printTransactions(int amount)
    {
        string returnString = "";

        // Find last "occupied" index of transactions
        int lastIndex = 0;
        for(int i = 0; i < transactions.Length; ++i)
        {
            if(transactions[i] == null)
            {
                lastIndex = i;
                break;
            }
        }

        if(lastIndex >= amount) // Only try to print the records if there are enough of the records to print
        {
            returnString += "--TRANSACTION HISTORY--\r\n";
            returnString += amount + " Most Recent Transactions:\r\n";

            // Print amount number of transactions
            for (int i = lastIndex; i >= lastIndex - amount; --i)
            {
                returnString += transactions[i] + "\r\n";
            }
        }
        else
        {
            returnString = "Not enough transaction records exist to create a transaction report.";
        }

        return returnString;
    }
}