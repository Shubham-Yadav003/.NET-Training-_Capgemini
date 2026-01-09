using System;
class Program
{
    private static int result;

    // private static void AddNumber(int param1, int param2)
    // {
    //     result = param1 + param2;
    // }


    public static bool IsApple(string str)
    {
        return str.Equals("I Phone X");
    }




    public static void Main()
    {
        // AddTwoNumber obj = new AddTwoNumber();
        // obj.ev_OddNumber += new AddTwoNumber.dg_OddNumber(EventMessage);
        // obj.Add();
        //*************************************************************************************//


        // Func<int,int,int> Addition = AddNumber;
        // int result = Addition(20,30);
        // Console.WriteLine($"Result: {result}");

        //***************************************************************************************//

        // Action<int, int> Addition = AddNumber;
        // Addition(20, 30);
        // Console.WriteLine($"Result: {result}");


        //**************************************************************************************//

        Predicate<string> CheckIfApple = IsApple;
        bool result = IsApple("I Phone X");
        if (result)
        {
            Console.WriteLine("It is an Iphone");
        }
    }

    // static void EventMessage()
    // {
    //     Console.WriteLine("Event executed: This is an odd number");
    // }
}