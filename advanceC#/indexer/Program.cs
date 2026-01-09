using System;
class Program
{
    public static void Main(string[] str)
    {
        Employee emp = new Employee();
        emp[0] = "str1";
        emp[1] = "str2";
        emp[2] = "str3";
        emp[3] = "str4";
        emp[4] = "str5";

        // for(int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine(emp[i]);
        // }

        Console.WriteLine($"value at: {emp[0]}");
        Console.WriteLine($"matching index found at: {emp["str2"]}");

    }
}