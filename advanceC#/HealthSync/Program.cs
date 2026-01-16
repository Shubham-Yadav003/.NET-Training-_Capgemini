class Program
{
    public static void Main()
    {
        Child obj = new Child();

        Console.WriteLine("Enter Id:");
        obj.Id = Console.ReadLine();

        Console.WriteLine("Enter Type:");
        obj.Type = Console.ReadLine();

        Console.WriteLine("Enter Stipend:");
        obj.Stipend = int.Parse(Console.ReadLine() ?? "0");

        if (obj.Validate())
        {
            obj.CalculateAmount();
        }
        else
        {
            Console.WriteLine("Invalid Id");
        }


    }
}