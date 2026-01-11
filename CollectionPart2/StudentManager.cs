using System;
using System.Collections.Generic;
public class StudentManager
{
    Dictionary<int,Student> dict = new Dictionary<int,Student>();

    public void AddStudent(Student student)
    {
        dict[student.Id] = student;
    }

    public void DisplayStudents()
    {
        foreach(var val in dict)
        {
            Console.WriteLine($"Key: {val.Key}, Name:{val.Value.Name}, Grade: {val.Value.Grade}");
        }
    }
} 