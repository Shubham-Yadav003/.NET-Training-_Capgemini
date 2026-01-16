// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System ;

namespace CalculatorApp
{
    public delegate int CalculatorDeligate(int number1, int number2) ;

    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator() ;
            
            CalculatorDeligate addDeligate = new CalculatorDeligate(calc.Add) ;
            int sum = addDeligate(10, 20) ;
            Console.WriteLine($"The Sum is : {sum}") ;

            CalculatorDeligate subDeligate = new CalculatorDeligate(calc.Subtract) ;
            int difference = subDeligate(30, 15) ;
            Console.WriteLine($"The Difference is : {difference}") ;

            CalculatorDeligate mulDeligate = new CalculatorDeligate(calc.Multiply) ;
            int product = mulDeligate(5, 4) ;
            Console.WriteLine($"The Product is : {product}") ;

            CalculatorDeligate divDeligate = new CalculatorDeligate(calc.Divide) ;
            int quotient = divDeligate(40, 8) ;
            Console.WriteLine($"The Quotient is : {quotient}") ;

            // Multicast using CalculatorDeligate (return value is from the last invoked method)
            CalculatorDeligate combined = addDeligate + subDeligate + mulDeligate + divDeligate;
            int combinedResult = combined(20, 5);
            Console.WriteLine($"Combined delegate returned (last result): {combinedResult}") ;

            // Multicast using Action<int,int> to invoke multiple methods and observe all outputs
            Action<int,int> addAction = (a,b) => Console.WriteLine($"Action Add: {calc.Add(a,b)}");
            Action<int,int> subAction = (a,b) => Console.WriteLine($"Action Subtract: {calc.Subtract(a,b)}");
            Action<int,int> mulAction = (a,b) => Console.WriteLine($"Action Multiply: {calc.Multiply(a,b)}");
            Action<int,int> divAction = (a,b) => Console.WriteLine($"Action Divide: {calc.Divide(a,b)}");

            Action<int,int> multiAction = addAction + subAction + mulAction + divAction;
            Console.WriteLine("Invoking multicast Action:");
            multiAction(20,5);

        }   
    }

}