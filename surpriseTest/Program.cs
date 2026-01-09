using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digital cash preetier");



        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        bool continueApp = true;

        while (continueApp)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Add Income Entry");
            Console.WriteLine("2. Add Expense Entry");
            Console.WriteLine("3. View Income Ledger");
            Console.WriteLine("4. View Expense Ledger");
            Console.WriteLine("5. Show Summary Report");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter your choice (1-6): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddIncomeEntry(incomeLedger);
                    break;
                case "2":
                    AddExpenseEntry(expenseLedger);
                    break;
                case "3":
                    DisplayIncomeLedger(incomeLedger);
                    break;
                case "4":
                    DisplayExpenseLedger(expenseLedger);
                    break;
                case "5":
                    DisplaySummaryReport(incomeLedger, expenseLedger);
                    break;
                case "6":
                    continueApp = false;
                    Console.WriteLine("\nThank you for using Petty Cash Ledger. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddIncomeEntry(Ledger<IncomeTransaction> ledger)
    {
        Console.WriteLine("ADD INCOME ENTRY");

        Console.Write("Enter Date (yyyy-MM-dd): ");
        string dateInput = Console.ReadLine();
        DateTime date;
        if (dateInput == "")
        {
            date = DateTime.Now;
        }
        else
        {
            date = DateTime.Parse(dateInput);
        }

        Console.Write("Enter Amount (in dollars): ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.Write("Enter Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Source (e.g., Main Cash, Bank Transfer, etc.): ");
        string source = Console.ReadLine();

        var income = new IncomeTransaction(0, date, amount, description, source);
        ledger.AddEntry(income);
    }

    static void AddExpenseEntry(Ledger<ExpenseTransaction> ledger)
    {
        Console.WriteLine("ADD EXPENSE ENTRY");

        Console.Write("Enter Date (yyyy-MM-dd)");
        string dateInput = Console.ReadLine();
        DateTime date;
        if (dateInput == "")
        {
            date = DateTime.Now;
        }
        else
        {
            date = DateTime.Parse(dateInput);
        }

        Console.Write("Enter Amount (in dollars): ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.Write("Enter Description: ");
        string description = Console.ReadLine();

        Console.WriteLine("\nSelect Category:");
        Console.WriteLine("1. Office");
        Console.WriteLine("2. Travel");
        Console.WriteLine("3. Food");
        Console.WriteLine("4. Stationery");
        Console.WriteLine("5. Other");
        Console.Write("Enter category number (1-5): ");

        string category = GetCategoryFromInput(Console.ReadLine());

        var expense = new ExpenseTransaction(0, date, amount, description, category);
        ledger.AddEntry(expense);
    }

    static string GetCategoryFromInput(string input)
    {
        return input switch
        {
            "1" => "Office",
            "2" => "Travel",
            "3" => "Food",
            "4" => "Stationery",
            "5" => "Other",
            _ => "Other"
        };
    }

    static void DisplayIncomeLedger(Ledger<IncomeTransaction> ledger)
    {
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("INCOME LEDGER");
        Console.WriteLine(new string('=', 50));

        if (ledger.GetCount() == 0)
        {
            Console.WriteLine("No income entries recorded yet.");
        }
        else
        {
            ledger.DisplayAll();
        }
    }

    static void DisplayExpenseLedger(Ledger<ExpenseTransaction> ledger)
    {
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("EXPENSE LEDGER");
        Console.WriteLine(new string('=', 50));

        if (ledger.GetCount() == 0)
        {
            Console.WriteLine("No expense entries recorded yet.");
        }
        else
        {
            ledger.DisplayAll();
        }
    }

    static void DisplaySummaryReport(Ledger<IncomeTransaction> incomeLedger, Ledger<ExpenseTransaction> expenseLedger)
    {
        decimal totalIncome = incomeLedger.CalculateTotal();
        decimal totalExpenses = expenseLedger.CalculateTotal();
        decimal netBalance = totalIncome - totalExpenses;

       
        Console.WriteLine("SUMMARY REPORT");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine($"Total Income:      ${totalIncome:F2}");
        Console.WriteLine($"Total Expenses:    ${totalExpenses:F2}");
        Console.WriteLine($"Net Balance:       ${netBalance:F2}");
        Console.WriteLine(new string('=', 50));

        if (netBalance >= 0)
        {
            Console.WriteLine($"Status: Petty Cash is in SURPLUS by ${netBalance:F2}");
        }
        else
        {
            Console.WriteLine($"Status: Petty Cash is in DEFICIT by ${Math.Abs(netBalance):F2}");
        }

        Console.WriteLine($"\nTotal Income Entries:  {incomeLedger.GetCount()}");
        Console.WriteLine($"Total Expense Entries: {expenseLedger.GetCount()}");
    }
}
