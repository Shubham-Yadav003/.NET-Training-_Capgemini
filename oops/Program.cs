using System;
// using System.ComponentModel.DataAnnotations;
using oops;
using System.Globalization;
class Program
{
    public string stringy { get; set; }
    public int val { get; set; }
    static void Main(string[] args)
    {
        // Employee emp = new Employee();
        // emp.AcceptDetails();
        // emp.CalculateSalaries();
        // emp.DisplayDetails();

        // StudentInfo obj = new StudentInfo();
        // StudentInfo obj2 = new StudentInfo("Ballu Pehelwan", 22, "B");


        // ClassInfo obj = new ClassInfo("Toyota", "Base Model", 2015);
        // obj.Display();
        // obj.CalculateAge();


        Program obj = new Program();


        while (true)
        {
            val = Convert.ToInt32(Console.ReadLine() ?? "0");
            stringy = Console.ReadLine() ?? "";
            if (val > 3 || val < 1)
            {
                break;
            }
            switch (val)
            {
                case 1:
                    obj.Upper(stringy);
                    break;

                case 2:
                    obj.Lower(stringy);
                    break;

                case 3:
                    obj.Title(stringy);
                    break;

                default:
                    Console.WriteLine($"INVALID SELECTION");
                    break;
            }
            Console.WriteLine("THE END");

        }

    }
    public void Upper(string stringy)
    {
        string temp = stringy.ToUpper();
        Console.WriteLine($"ToUpper: {temp}");
    }

    public void Lower(string stringy)
    {
        string temp = stringy.ToLower();
        Console.WriteLine($"ToLower: {temp}");
    }

    // public void Title(string stringy)
    // {
    //     TextInfo textInfo = new CultureInfo("en-US").TextInfo;
    //     string titleCase = textInfo.ToTitleCase(stringy);
    //     Console.WriteLine($"TitleCase: {titleCase}");
    // }

    public void Title(string stringy)
    {
        string[] words = stringy.Split(' '); // to convert string to array based on "  "
        string result = "";

        foreach (string word in words)
        {
            if (word.Length > 0)
            {
                result += char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ";
            }
        }

        Console.WriteLine($"Title Case: {result.Trim()}");

    }

}
