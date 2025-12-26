using System;

public class ClassInfo
{
    public string make { get; set; }
    public string model { get; set; }
    public int age { get; set; }

    public ClassInfo(string make, string model, int age)
    {
        this.make = make;
        this.model = model;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Make: {make} Model: {model} Age: {age}");
    }

    public void CalculateAge()
    {
        int val = 2024 - age;
          Console.WriteLine($"Value of Age: {val}");
    }
}