using System.Data ;
using System ;
using System.Data ;
using System.Linq ;
class Employee : DataTable
{
    public Employee()
    {
        this.Columns.Add("Id", typeof(int)) ;
        this.Columns.Add("Name", typeof(string)) ;
        this.Columns.Add("Age", typeof(int)) ;
        this.Columns.Add("Department", typeof(string)) ;
        this.Columns.Add("Salary", typeof(int)) ;
    }
}




public class Program
{
    public static void Main(string[] args)
    {
        // data-source
        // create an instance of the Employees data-table
        Employee employees = new Employee() ;

        // add some rows to the Employees data-table
        employees.Rows.Add(1, "Kundan", 25, "IT", 50000) ;
        employees.Rows.Add(2, "Gaurav", 30, "HR", 60000) ;
        employees.Rows.Add(3, "Krishna", 22, "IT", 55000) ;
        employees.Rows.Add(4, "Shubham", 28, "Finance", 70000) ;
        employees.Rows.Add(5, "Sunny", 35, "IT", 80000) ;
        employees.Rows.Add(6, "Danny", 40, "IT", 90000) ;
        employees.Rows.Add(7, "Mia", 45, "HR", 65000) ;
        employees.Rows.Add(8, "Sophia", 29, "Finance", 72000) ;
        employees.Rows.Add(9, "Liam", 32, "IT", 78000) ;
        employees.Rows.Add(10, "Noah", 27, "HR", 62000) ;

        // Write The Query (Linq Query Syntax)     (filter employees from IT department by ordering by Salary in descending order)
        var result = from emp in employees.AsEnumerable()
                     where emp.Field<string>("Department") == "IT"
                     orderby emp.Field<int>("Salary") descending
                     select new
                    {
                    Id = emp.Field<int>("Id"),        // Anonymous Type (we can only pass )
                    Name = emp.Field<string>("Name"),
                    Age = emp.Field<int>("Age"),
                    Department = emp.Field<string>("Department"),
                    Salary = emp.Field<int>("Salary") 
                    };


        // // Write The Query (Linq Query Syntax)     (filter employees from IT department by ordering by Salary in descending order)
        // var result = from emp in employees.AsEnumerable()
        //              where emp.Field<string>("Department") == "IT"
        //              orderby emp.Field<int>("Salary") descending
        //              select emp ;

        // Execute The Query
        foreach (var item in result)
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Age: {item.Age}, Department: {item.Department}, Salary: {item.Salary}") ;
        }
    }
}