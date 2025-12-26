using System;

class Calculator()
{
    public int Add(int n)
    {
        int num1 = 30;
        int num2 = n;
        return num1 + num2;
    }
    // overriding !! 
    public int Add(string s1, string s2) // type of param
    {
        string s3 = s1 + s2;
        Console.WriteLine($"String: {s3}");
        return 0;
    }

    public int Add(int n1, int n2) // no of params 
    {
        int num1 = n1;
        int num2 = n2;
        return num1 + num2;
    }

    // sequence of params
}