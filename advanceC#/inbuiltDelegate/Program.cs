using System;

class Demo
{
    public void Rerverse(string str)
    {
        Console.WriteLine("Before reversing the string:");

        Console.WriteLine(str);

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);

        string reverseString = new String(charArray);
        Console.WriteLine($"reverse string: {reverseString}");



    }

    public bool isPalindrome(string str)
    {
        int n = str.Length;
        int left = 0;
        int right = n - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                Console.WriteLine("Not Palindrome");
                return false;
            }
            left++;
            right--;
        }
        Console.WriteLine("It is a palindrome");
        return true;
    }
}

class Program
{
    static Action<string> actionDelegate; // must be void 
    static Func<string, bool> funcDelegate; // along with argument also contains return type in decleraion

    public static void Main()
    {
        Demo obj = new Demo();
        Console.WriteLine("Enter string:");

        string str = Console.ReadLine().ToLower();

        Console.WriteLine("Enter choice:");
        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "reverse":
                actionDelegate = obj.Rerverse;
                actionDelegate(str);
                break;


            case "ispalindrome":
                funcDelegate = obj.isPalindrome;
                funcDelegate(str);
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;


        }

    }
}