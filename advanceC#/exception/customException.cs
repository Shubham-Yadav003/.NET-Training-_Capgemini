using System;

class ArgumentException : Exception
{
    public ArgumentException(string message) : base(message)
    {
        Console.WriteLine($"Invalid: {message}");
    }
}


class InvalidOperationException : Exception
{
    public InvalidOperationException(string message) : base(message)
    {
        Console.WriteLine($"Invalid score: {message}");
    }
}

