class program
{

    public static void Main()
    {
        Account acc = new Account();

        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Exit");
        Console.WriteLine("Enter your choice");

        try
        {
            while (true)
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter deposit amount");
                        double depositAmount = double.Parse(Console.ReadLine());
                        // while (!double.TryParse(Console.ReadLine(), out depositAmount))
                        // {
                        //     Console.WriteLine("Invalid input. Please enter a valid amount.");
                        // }
                        double val1 = acc.Deposit(depositAmount);
                        Console.WriteLine($"available balance: {val1}");
                        break;

                    case 2:

                        Console.WriteLine("Enter withdraw amount");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        // while (!double.TryParse(Console.ReadLine(), out withdrawAmount))
                        // {
                        //     Console.WriteLine("Invalid input. Please enter a valid amount in double.");
                        // }
                        
                        double val2 = acc.Withdraw(withdrawAmount);
                        Console.WriteLine($"available balance: {val2}");
                        break;

                    case 3:
                        Console.WriteLine("Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("\n1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception occures {ex.Message}");
        }


    }
}