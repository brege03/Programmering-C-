//Account class with deposit and balance method
class Account
{
    public string Name { get; set; } //Auto-implement
    private decimal balance; //Instance variable

    //Account constructor that receives two parameters
    public Account(string accountName, decimal initalBalance)
    {
        Name = accountName;
        Balance = initalBalance;
    }

    //Balance property with validation
    public decimal Balance
    {
        get
        {
            return balance;
        }
        private set
        {
            //validate that the balance is greater than 0.0; if not it keeps its prior value
            if (value > 0.0m)
            {
                balance = value;
            }
        }
    }

    // method that depoits only a valid amount to the balance
    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m) //if depositAmount is valid
        {
            Balance = Balance + depositAmount; //add to amount
        }
    }

    public void Withdraw(decimal withdrawAmount)
    {
        if (withdrawAmount > Balance)
        {
            Console.WriteLine("Withdrawal amount exceeded balance amount");
        }
        else if (withdrawAmount <= 0.0m)
        {
            Console.WriteLine("Withdrawal amount is invalid");
        }
        else
        {
            Balance = Balance - withdrawAmount;
        }
    }
}