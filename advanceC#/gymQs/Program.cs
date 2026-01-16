class Program
{
    public static void Main()
    {
        try { 
        Logic obj = new Logic();
        Console.WriteLine("Enter tier");
         obj.Tier = Console.ReadLine().ToLower();

        Console.WriteLine("Enter Duration");
         obj.NumberOfMonth = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Price");
         obj.MonthPrice = int.Parse(Console.ReadLine());

        if (obj.ValidateEnrollment())
        {
            double result = obj.CalculateTotalBill();
            Console.WriteLine($"Result is: {result}");
        }

        }
        catch(FormatException ex){
            Console.WriteLine(ex.Message);
        }

    }
}