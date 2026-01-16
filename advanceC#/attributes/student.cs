using System;

// define a class Student
public class Student
{
    // Properties Definition
    public int RollNo { get; set; }
    public string Name { get; set; }

    // No Argument Constructor
    public Student()
    {
        RollNo = 0;
        Name = string.Empty;
    }

    // Parameterized Constructor
    public Student (int rollNo, string name)
    {
        RollNo = rollNo;
        Name = name;
    }

    // Method to display student data
    public void Display()
    {
        Console.WriteLine("Roll No is : {0}", RollNo);
        Console.WriteLine("Name is : {0}", Name);
    }

}