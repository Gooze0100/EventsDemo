namespace DemoLibrary;

//always inherit from EventArgs class if you are using that class because of all the extra benefits
public class OverdraftEventArgs : EventArgs
{
    // also have private set if it should not be changed
    public decimal AmountOverdrafter { get; private set; }
    public string MoreInfo { get; private set; }
    // listen to changes to this in your code if somebody changed and you can stop it
    public bool CancelTransaction { get; set; } = false;

    //public decimal AmountOverdrafter { get; set; }
    //public string MoreInfo { get; set; }

    // passing address to the house
    public OverdraftEventArgs(decimal amountOverdrafter, string moreInfo)
    {
        AmountOverdrafter = amountOverdrafter;
        MoreInfo = moreInfo;
    }
}
