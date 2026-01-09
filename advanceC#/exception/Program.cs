using System;
class Program
{
    public static void Main()
    {

        // Practice1 obj = new Practice1();
        // obj.Helper();

        Practice2 obj2 = new Practice2();
        obj2.Helper2();
        obj2.CalculateTotalScore(5);
        
        // try{
        //     throw new MyException();
        // }
        // catch(Exception e){
        //     Console.WriteLine($"Exception caught here {e.Message}");
        // }

        // int num1 = 0, num2 = 0, result = 0;
        // int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };

        // try
        // {
        //     Console.WriteLine("Enter num1");
        //     num1 = int.Parse(Console.ReadLine());

        //     Console.WriteLine("Enter num2");
        //     num2 = int.Parse(Console.ReadLine());



        //     {
        //         result = num1 / num2;
        //     }
        //     for(int i=0;i<9;i++){
        //         Console.WriteLine(arr[i]);
        //     }
        // }
        // catch(IndexOutOfRangeException e){
        //     Console.WriteLine($"Index is out of range: {e.Message}");
        // }
        // catch(DivideByZeroException e){
        //     Console.WriteLine($"Can't divide by zero {e.Message}");
        // }
        // catch(FormatException e){
        //     Console.WriteLine($"Enter number only {e.Message}");
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message.ToString());
        // }
        // finally
        // {
        //     Console.WriteLine($"Output is; {result}");
        // }

    }
}
