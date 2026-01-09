using System;


public class ExpenseTransaction : Transaction
{
    public string Category { get; set; }

    public ExpenseTransaction(int id, DateTime date, decimal amount, string description, string category)
        : base(id, date, amount, description)
    {
        Category = category;
    }

    public override string GetSummary()
    {
        return $"[EXPENSE] {Date:dd/MM/yyyy} | Amount: ${Amount:F2} | Category: {Category} | Description: {Description}";
    }
}
