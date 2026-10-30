using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulator___GUI
{
    using static Program;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public partial class Form2 : Form
    {
        bool transactionSuccessful = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblLoggedIn.Text = "Logged In: " + accounts[selectedIndex].User;

            if (selectedIndex == 0) // If the master account is logged in, then enable  
            {                                           // the view-all-accounts button
                btnViewAllAccountData.Visible = true;
            }
        }

        private void BtnViewBal_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Balance: " + accounts[selectedIndex].Balance.ToString("C");
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            double oldBal = accounts[selectedIndex].Balance; // Retrieve current account balance to be compared to new balance after deposit
            string input = txtAmount.Text;

            if (Double.TryParse(input, out double result) == true && Convert.ToDouble(input) >= 0.01)
            {
                accounts[selectedIndex].Deposit(result);
                accounts[selectedIndex].setTransaction("Deposit", result);
                txtOutput.Text = "DEPOSIT SUCCESSFUL\r\nAmount: " + result.ToString("C") + "\r\nOld Balance: " + oldBal.ToString("C") + "\r\nNew Balance: " + accounts[selectedIndex].Balance.ToString("C");
                txtAmount.Text = "";
            }
            else
            {
                txtOutput.Text = "ERROR: Invalid entry. Please try again.";
            }
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            double oldBal = accounts[selectedIndex].Balance; // Retrieve current account balance to be compared to new balance after deposit
            bool transactionSuccessful = false;
            string input = txtAmount.Text;

            if (Double.TryParse(input, out double result) == true && Convert.ToDouble(input) >= 0.01)
            {
                transactionSuccessful = accounts[selectedIndex].Withdraw(result);

                if (transactionSuccessful)
                {
                    txtOutput.Text = "WITHDRAWAL SUCCESSFUL\r\nAmount: " + result.ToString("C") + "\r\nOld Balance: " + oldBal.ToString("C") + "\r\nNew Balance: " + accounts[selectedIndex].Balance.ToString("C");
                    accounts[selectedIndex].setTransaction("Withdrawal", result);
                    txtAmount.Text = "";
                }
                else
                {
                    txtOutput.Text = "ERROR: An unexpected error occurred. Make sure your balance is high enough for your withdrawal.";
                }
            }
            else
            {
                txtOutput.Text = "ERROR: Invalid entry. Please try again.";
            }
        }

        private void BtnViewTransactions_Click(object sender, EventArgs e)
        {
            txtOutput.Text = accounts[selectedIndex].printTransactions(3);
        }

        private void BtnViewAllAccountData_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            foreach (Account account in accounts)
            {
                txtOutput.Text += "Account #: " + account.AcctNum;
                txtOutput.Text += "\r\nUser: " + account.User;
                txtOutput.Text += "\r\nBalance: " + account.Balance.ToString("C") + "\r\n";
                txtOutput.Text += account.printTransactions(3);
                txtOutput.Text += "\r\n\r\n";
            }
        }
    }
}
