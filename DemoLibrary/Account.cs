namespace DemoLibrary;

public class Account
{
    //only approved transactions are going to change and update the list
    // EventHandler is generic 
    // inside brackets we pass in type that we return information about the event
    // if it gets triggered that means transaction has been approved
    // so we declare event handler, that is middle piece 
    // so we have two sides, 
    // 1. what kicks the event
    // 2. what listens to event
    // in between is event handler
    // that is all with the events you create EventHandler with return type
    // typically you pass the class officialy class instance, but you don't have to
    // it was before that any object you pass through this EventHandler it had to inherit from Event Args, but most probably C# 6 from that it is not required
    public event EventHandler<string> TransactionApprovedEvent;
    // trigger when overdraft is happening
    //public event EventHandler<decimal> OverdraftEvent;
    public event EventHandler<OverdraftEventArgs> OverdraftEvent;

    public string AccountName { get; set; }
    // for money decimal is precise and double is not
    public decimal Balance { get; private set; }
    // private seen just in this class
    private List<string> _transactions = new();

    // IReadOnlyList does not let do any changes to the list, just lest to read it
    public IReadOnlyList<string> Transactions
    {
        get { return _transactions.AsReadOnly(); }
    }

    public bool AddDeposit(string depositName, decimal amount)
    {
        _transactions.Add($"Deposited {string.Format("{0:C2}", amount)} for {depositName}");
        Balance += amount;
        // first parameter is sender, who triggers this event, and it is this class
        // this null check helps with race condition, because it just insstantly checks if it is null or not
        // you can pass instead of depositName EventArgs.Empty, but it should inherit from Event args class
        TransactionApprovedEvent?.Invoke(this, depositName);
        return true;
    }

    public bool MakePayment(string paymentName, decimal amount, Account backupAccount = null)
    {
        // Ensures we have enough money
        if (Balance >= amount)
        {
            _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
            Balance -= amount;
            TransactionApprovedEvent?.Invoke(this, paymentName);
            return true;
        }
        else
        {
            // We don't have enough money so we check to see if we have a backup account
            if (backupAccount != null)
            {
                // Check to see if we have enough money in the backup account
                if ((backupAccount.Balance + Balance) >= amount)
                {
                    // We have enough backup funds so transfer the amount to this account
                    // and then complete the transaction.
                    decimal amountNeeded = amount - Balance;
                    // creating class instance
                    OverdraftEventArgs args = new OverdraftEventArgs(amountNeeded, "Extra info");
                    // pass the class instance, just passing the reference value
                    OverdraftEvent?.Invoke(this, args);

                    if (args.CancelTransaction == true)
                    {
                        // The overdraft failed so this transaction failed.
                        return false;
                    }

                    bool overdraftSucceeded = backupAccount.MakePayment("Overdraft Protection", amountNeeded);

                    // This should always be true but we will check anyway
                    if (overdraftSucceeded == false)
                    {
                        // The overdraft failed so this transation failed.
                        return false;
                    }

                    AddDeposit("Overdraft Protection Deposit", amountNeeded);

                    _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                    Balance -= amount;
                    TransactionApprovedEvent?.Invoke(this, paymentName);
                    // pass amount we overdraft
                    //OverdraftEvent?.Invoke(this, amount);
                    // pass creation info
                    //OverdraftEvent?.Invoke(this, new OverdraftEventArgs { AmountOverdrafter = amountNeeded, MoreInfo = "Extra info" });
                    //OverdraftEvent?.Invoke(this, new OverdraftEventArgs(amountNeeded, "Extra info"));

                    return true;
                }
                else
                {
                    // Not enough backup funds to do anything
                    return false;
                }
            }
            else
            {
                // No backup so we fail and do nothing
                return false;
            }
        }
    }
}

// think of Events like when you want to change anything, like you have a lits and you add something to the list and it doesnt show anything, because you need to update it.

// As I understand Delegate is for something to call certain functions at certain times 
// and Events is for changes if you want to observe all the time and it listens and responds something