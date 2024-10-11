using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        Customer customer = new();
        public Dashboard()
        {
            InitializeComponent();

            LoadTestingData();

            WireUpForm();
        }

        private void LoadTestingData()
        {
            customer.CustomerName = "Time Sharan";
            customer.CheckingAccount = new Account();
            customer.SavingsAccount = new Account();

            customer.CheckingAccount.AccountName = "Time's Checking Account";
            customer.SavingsAccount.AccountName = "Time's Savings Account";

            // if value is static you need to add M for decimal value
            customer.CheckingAccount.AddDeposit("Initial Balance", 155.43M);
            customer.SavingsAccount.AddDeposit("Initial Balance", 98.45M);
        }

        private void WireUpForm()
        {
            customerText.Text = customer.CustomerName;
            checkingTransactions.DataSource = customer.CheckingAccount.Transactions;
            savingsTransactions.DataSource = customer.SavingsAccount.Transactions;
            checkingBalanceValue.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
            savingsBalanceValue.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);

            // listen to those Events RaiseTransactionApprovedEvent?.Invoke(this, paymentName);
            // lightBolt means it is Event
            // when writting += it suggests for you Event functions name and you just press TAB
            // when it is being call functions is being called
            // += means we can add something to the events but it can remove somethins away too
            // REALITY IS THAT IF YOU DONT REMOVE EVENT LISTENERS BEFORE FORM CLOSES THERE MAYBE HAVE BEEN A CASE WHERE FORM STAYS OPEN IN MEMORY AND ARE NOT GARBAGE COLLLECTOR
            // SO THIS IS MEMORY LEAKAGE AND YOU SHOULD CLOSE IT 
            // ALWAYS CLEAN YOUR APPLICATIONS
            customer.CheckingAccount.TransactionApprovedEvent += CheckingAccount_TransactionApprovedEvent;
            customer.SavingsAccount.TransactionApprovedEvent += SavingsAccount_TransactionApprovedEvent;
            customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        //private void CheckingAccount_OverdraftEvent(object? sender, decimal e)
        private void CheckingAccount_OverdraftEvent(object? sender, OverdraftEventArgs e)
        {
            errorMessage.Text = $"You had an overdraft protection transfer of {string.Format("{0:C2}", e.AmountOverdrafter)}";
            // do not let go through for overdraft
            //e.CancelTransaction = true;
            // if checked deny transaction we will deny overdraft if it is checked
            e.CancelTransaction = denyOverdraft.Checked;
            errorMessage.Visible = true;
        }

        private void SavingsAccount_TransactionApprovedEvent(object? sender, string e)
        {
            savingsTransactions.DataSource = null;
            savingsTransactions.DataSource = customer.SavingsAccount.Transactions;
            savingsBalanceValue.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);
        }

        // this two parameters is just the same as Event we created
        private void CheckingAccount_TransactionApprovedEvent(object? sender, string e)
        {
            // reset transaction list
            checkingTransactions.DataSource = null;
            checkingTransactions.DataSource = customer.CheckingAccount.Transactions;
            checkingBalanceValue.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
        }

        // this is listener to event handler
        private void recordTransactionsButton_Click(object sender, EventArgs e)
        {
            Transactions transactions = new(customer);
            transactions.Show();
        }

        private void errorMessage_Click(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }
    }
}

// it passes the method to click event
//errorMessage.Click += errorMessage_Click;