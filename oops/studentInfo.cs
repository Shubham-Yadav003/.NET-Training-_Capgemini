using System;

public class StudentInfo
{
    public string name { get; set; }
    public int age { get; set; }

    public string grade { get; set; }
    public StudentInfo()
    {
        name = "Bala";
        age = 22;
        grade = "A";
        Console.WriteLine($"Name: {name} Age: {age} Grade: {grade}");
    }

    public StudentInfo(string name, int age, string grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
        Console.WriteLine($"Name: {name} Age: {age} Grade: {grade}");
    }
}