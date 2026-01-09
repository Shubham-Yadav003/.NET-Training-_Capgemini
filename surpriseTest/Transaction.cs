using System;

// Abstract base class for all transactions
public abstract class Transaction
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }

    protected Transaction(int id, DateTime date, decimal amount, string description)
    {
        Id = id;
        Date = date;
        Amount = amount;
        Description = description;
    }

    
    public abstract string GetSummary();
}
