class Account
{
    public double AccountNumber { get; set; }
    public double Balance { get; set; }

    public double Deposit(double amount)
    {
        try
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");

            }
            Balance += amount;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
             Console.WriteLine($"Exception ocured {ex.Message}");
        }

        return Balance;
    }

    
    public double Withdraw(double amount)
    {
        try
        {
            if(amount < 0 || amount >= Balance)
            {
                throw new ArgumentException("Withdraw amount must be positive");
            }
            Balance -= amount;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
             Console.WriteLine($"Exception ocured {ex.Message}");
        }

        return Balance;

    }
}