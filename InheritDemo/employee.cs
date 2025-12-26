using System;

class Employee
{
    public int empId { get; set; }
    public string name { get; set; } = string.Empty;
    public float salary { get; set; }
    public Employee()
    {

    }

    public Employee(int empId, string name, float salary)
    {
        this.empId = empId;
        this.name = name;
        this.salary = salary;
    }

    public override string ToString()
    {
        return $"Employee details are \n"
        + $"Employee Id is {empId}\n"
        + $"Employee name is {name}\n"
        + $"Employee salary is {salary}\n";
    }

    public void Add(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine($"sum: {sum}");
    }
    
}