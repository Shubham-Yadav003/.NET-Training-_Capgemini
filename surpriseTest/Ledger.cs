using System;
using System.Collections.Generic;

// Generic Ledger class to store and manage any type of transaction
public class Ledger<T> where T : Transaction
{
    private List<T> transactions = new List<T>();
    private int nextId = 1;

    
    public void AddEntry(T entry)
    {
        entry.Id = nextId++;
        transactions.Add(entry);
        Console.WriteLine($"Entry added successfully! (ID: {entry.Id})");
    }

   
    public List<T> GetAllTransactions()
    {
        return transactions;
    }

    
    public List<T> GetTransactionsByDate(DateTime date)
    {
        List<T> result = new List<T>();
        foreach (var transaction in transactions)
        {
            if (transaction.Date.Date == date.Date)
            {
                result.Add(transaction);
            }
        }
        return result;
    }

 
    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var transaction in transactions)
        {
            total += transaction.Amount;
        }
        return total;
    }


    public void DisplayAll()
    {
        if (transactions.Count == 0)
        {
            Console.WriteLine("  [No transactions yet]");
            return;
        }

        foreach (var transaction in transactions)
        {
            Console.WriteLine($"  {transaction.GetSummary()}");
        }
    }

 
    public int GetCount()
    {
        return transactions.Count;
    }
}
