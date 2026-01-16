class InvalidTierException : Exception
{
    // Default constructor with no arguments
    public InvalidTierException() : base("An error occurred")
    {
        // Console.WriteLine("An error occurred");
    }

    // Constructor with message
    public InvalidTierException(string message) : base(message)
    {
        // Console.WriteLine(message);
    }
}