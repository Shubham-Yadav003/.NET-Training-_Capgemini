using System;
class Student
{
    public int Grade { get; set; }
    public delegate void EventDelegate(int val); // delegate declaration

    public event EventDelegate objEvent; // event declaration

    public Student()
    {
        Grade = 0;
    }

    public void GradeChange(int number)
    {
        if (number != Grade && number >=0 && number<=100)
        {
            Grade = number;
            objEvent(number);
        }
        else
        {
            Console.WriteLine("No grade changed !");
        }
    }
}

class Program
{
    static void helper(int val)
    {
        Console.WriteLine($"✅ Event successfully triggered! Grade: {val}");
    }
    public static void Main()
    {
        Student obj = new Student();
        obj.objEvent += helper;

        int input = 0;
        Console.WriteLine("Enter grade");
        while(!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Enter grade");
             
        }
        obj.GradeChange(input);

       
    }
}