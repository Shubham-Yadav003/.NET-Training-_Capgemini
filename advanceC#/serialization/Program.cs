using System;
using System.IO;
using System.Text.Json;
public class Program
{
    public static void Main()
    {
        Employee emp = new Employee();
        while (true)
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Delete all Employee");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddEmployee(emp);
                    break;
                case 2:
                    ViewEmployees();
                    break;
                case 3:
                    DeleteAllEmployees();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    public static void AddEmployee(Employee emp)
    {  
       
        Console.Write("Enter Employee Id: ");
        emp.Id = int.Parse(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        emp.Name = Console.ReadLine();
        Console.Write("Enter Employee Department: ");
        emp.Department = Console.ReadLine();
        //write in json file using serialization
        string json = JsonSerializer.Serialize(emp);
        File.AppendAllText("employees.json",json+Environment.NewLine);
        Console.WriteLine("Employee added successfully.");

    }
    public static void ViewEmployees()
    {
        if (File.Exists("employees.json"))
        {
            Console.WriteLine("Employee Records:");
            string[] lines = File.ReadAllLines("employees.json");
            foreach(string line in lines)
            {
                Employee emp = JsonSerializer.Deserialize<Employee>(line);
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}");
            }
        }
        else
        {
            Console.WriteLine("No employee records found.");
        }
    }
    public static void DeleteAllEmployees()
    {
        if (File.Exists("employees.json"))
        {
            File.Delete("employees.json");
            Console.WriteLine("All employee records deleted successfully.");
        }
        else
        {
            Console.WriteLine("No employee records to delete.");
        }
    }
}
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

