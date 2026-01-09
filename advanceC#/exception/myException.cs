using System;

class MyException: Exception
{
    public MyException(string s)
    {
        Console.WriteLine($"user defined exception");
    }
} 