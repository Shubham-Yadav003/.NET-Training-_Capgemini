using System;

class Practice1
{
    int temperature = 0; double result = 0;
    char ch;

    public void Helper()
    {
        try
        {
            Console.WriteLine($"Enter input value:");
            temperature = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter unit you want to convert to->");
            ch = char.Parse(Console.ReadLine());

            if (ch != 'F' && ch != 'C')
            {
                Console.WriteLine("inappropriate unit conversion");
                return;
            }
            double calc;
            switch (ch)
            {
                case 'C':
                    calc = (temperature - 32) * 5 / 9;
                    Console.WriteLine($"Fahreheit value is: {calc:F2}");
                    break;

                case 'F':
                    calc = (temperature * 9 / 5) + 32;
                    Console.WriteLine($"Fahreheit value is: {calc:F2}");
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

        }

        catch (SystemException e)
        {
            Console.WriteLine($"Exception found: {e.Message}");
        }


    }

}