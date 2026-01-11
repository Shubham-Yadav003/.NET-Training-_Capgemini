using System;

class Program
{
    public static void Main()
    {
        StudentManager obj = new StudentManager();

        Console.WriteLine("Enter no of students:");
        int input = int.Parse(Console.ReadLine());

        while (input != 0)
        {
            Console.WriteLine("Enter Id:");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter grade:");
            string Grade = Console.ReadLine();

            Student obj_new = new Student(Id, Name, Grade);
            obj.AddStudent(obj_new);

            input--;
            
        }
        obj.DisplayStudents();
    }
}