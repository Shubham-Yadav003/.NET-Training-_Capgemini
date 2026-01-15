using System;
class Calc
{


    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }


    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }



    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }


    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException();
        }
        return num1 / num2;
    }
}

class Program
{
    // public static int Num1 { get; set; }
    // public static int Num2 { get; set; }
    // public static string operation { get; set; }
    public delegate double DelegateFunc(double Num1, double Num2);

    public static void Main()
    {
        Calc obj = new Calc();

        Console.WriteLine("Enter Number1");
        double Num1 = 0;
        while (!double.TryParse(Console.ReadLine(), out Num1))
        {
            Console.WriteLine("No is Invalid, Enter valid number");
            Console.WriteLine("Enter Number1");
        }


        Console.WriteLine("Enter Number2");
        double Num2 = 0;
        while (!double.TryParse(Console.ReadLine(), out Num2))
        {
            Console.WriteLine("No is Invalid, Enter valid number");
            Console.WriteLine("Enter Number2");
        }

        string operation = Console.ReadLine();


        switch (operation)
        {
            case "add":
                DelegateFunc addFunc = new DelegateFunc(obj.Add);
                double sum = addFunc(Num1, Num2);
                Console.WriteLine($"sum: {sum}");
                break;

            case "subtract":
                DelegateFunc subFunc = new DelegateFunc(obj.Subtract);
                double sub = subFunc(Num1, Num2);
                Console.WriteLine($"sum: {sub}");
                break;

            case "Multiply":
                DelegateFunc mulFunc = new DelegateFunc(obj.Multiply);
                double mul = mulFunc(Num1, Num2);
                Console.WriteLine($"sum: {mul}");
                break;

            case "Divide":
                DelegateFunc divFunc = new DelegateFunc(obj.Divide);
                double div = divFunc(Num1, Num2);
                Console.WriteLine($"sum: {div}");
                break;

            default:
                Console.WriteLine("Invalid Choice");
                return;
        }


    }
}