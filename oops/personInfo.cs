using System;

public class PersonInfo
{
    public string name { get; set; }
    public string Address { get; set; }
    public int age { get; set; }

    public PersonInfo(string name, string Address, int age)
    {
        this.name = name;
        this.Address = Address;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Make: {name} Model: {Address} Age: {age}");
    }
}