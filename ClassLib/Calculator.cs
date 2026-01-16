using System ;

namespace CalculatorApp {   // Alll 4 method-Name are same and have same parameters, but they are performing different operations as Delegates
    public class Calculator
{
    int number1 = 0 ;
    int number2 = 0 ;


    public int Add(int number1, int number2)
    {
        return number1 + number2 ;
    }

    public int Subtract(int number1, int number2)
    {
        return number1 - number2 ;
    }

    public int Multiply(int number1, int number2)
    {
        return number1 * number2 ;
    }

    public int Divide(int number1, int number2)
    {
        return number1 / number2 ;
    }
}
}