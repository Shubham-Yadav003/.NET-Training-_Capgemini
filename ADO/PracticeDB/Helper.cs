using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDB
{
    internal class Helper
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader dataReader;

        string conStr = "Data Source=Lenovo_Ideapad\\SQLEXPRESS;Initial Catalog=CompanyDB;Integrated Security=True;";

        public void InsertDepartment()
        {

            Console.WriteLine("Prompt:");
            Console.WriteLine("Enter Department Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Location :");
            string loc = Console.ReadLine();

            string query = $"insert into Departments values({id},'{name}', '{loc}')";
            connection = new SqlConnection(conStr);
            connection.Open();
            Console.WriteLine("Connection Opened");

            cmd = new SqlCommand(query, connection);
            int cnt = cmd.ExecuteNonQuery();

            Console.WriteLine($"{cnt} record(s) inserted");
            connection.Close();
        }

        public void InsertEmployee()
        {
            Console.WriteLine("Prompt:");
            Console.WriteLine("Enter Employee Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department Id:");
            int departmentId = int.Parse(Console.ReadLine());

            connection = new SqlConnection(conStr);
            connection.Open();

            // Check if Department exists
            string checkQuery = $"SELECT COUNT(*) FROM Departments WHERE DepartmentId={departmentId}";
            cmd = new SqlCommand(checkQuery, connection);
            int count = (int)cmd.ExecuteScalar();

            if (count == 0)
            {
                Console.WriteLine("Invalid Department Id!");
                connection.Close();
                return;
            }

            // Insert employee
            string insertQuery = $"insert into Employees values({id},'{name}', {salary}, {departmentId})";
            cmd = new SqlCommand(insertQuery, connection);
            int cnt = cmd.ExecuteNonQuery();

            Console.WriteLine($"{cnt} record(s) inserted");
            connection.Close();
        }

        public void SelectAllDepartments()
        {
            string query = "SELECT * FROM Departments";
            connection = new SqlConnection(conStr);
            connection.Open();
            Console.WriteLine("Connection Opened");

            cmd = new SqlCommand(query, connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int DepartmentId = int.Parse(dataReader["DepartmentId"].ToString());
                string DepartmentName = dataReader["DepartmentName"].ToString();
                string Location = dataReader["Location"].ToString();
                

                Console.WriteLine(
                    $"Id: {DepartmentId}, " +
                    $"Name: {DepartmentName}, " +
                    $"Location: {Location}"
                );
            }

            dataReader.Close();
            connection.Close();
        }


        public void SelectAllEmployees()
        {
            string query = "SELECT * FROM Employees";
            connection = new SqlConnection(conStr);
            connection.Open();
            Console.WriteLine("Connection Opened");

            cmd = new SqlCommand(query, connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int EmployeeId = int.Parse(dataReader["EmployeeId"].ToString());
                string EmployeeName = dataReader["EmployeeName"].ToString();
                decimal Salary = decimal.Parse(dataReader["Salary"].ToString());
                int DepartmentId = int.Parse(dataReader["DepartmentId"].ToString());

                Console.WriteLine(
                    $"Id: {EmployeeId}, " +
                    $"Name: {EmployeeName}, " +
                    $"Salary: {Salary}, " +
                    $"Department Id: {DepartmentId}"
                );
            }

            dataReader.Close();
            connection.Close();
        }

        public void SelectEmployeesWithDepartment()
        {
            string query = @"SELECT e.EmployeeId,
                                    e.EmployeeName,
                                    e.Salary,
                                    d.DepartmentName
                             FROM Employees e
                             JOIN Departments d
                                  ON e.DepartmentId = d.DepartmentId";
            connection = new SqlConnection(conStr);
            connection.Open();
            Console.WriteLine("Connection Opened");

            cmd = new SqlCommand(query, connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int EmployeeId = int.Parse(dataReader["EmployeeId"].ToString());
                string EmployeeName = dataReader["EmployeeName"].ToString();
                decimal Salary = decimal.Parse(dataReader["Salary"].ToString());
                string DepartmentName = dataReader["DepartmentName"].ToString();

                Console.WriteLine(
                    $"Id: {EmployeeId}, " +
                    $"Name: {EmployeeName}, " +
                    $"Salary: {Salary}, " +
                    $"Department: {DepartmentName}"
                );
            }

            dataReader.Close();
            connection.Close();
        }

        public void UpdateEmployeeSalary()
        {
            Console.WriteLine("Prompt:");
            Console.WriteLine("Enter Employee Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New Salary:");
            decimal salary = decimal.Parse(Console.ReadLine());

            string query = $"UPDATE Employees SET Salary={salary} WHERE EmployeeId={id}";
            connection = new SqlConnection(conStr);
            connection.Open();
            Console.WriteLine("Connection Opened");

            cmd = new SqlCommand(query, connection);
            int cnt = cmd.ExecuteNonQuery();

            if (cnt > 0)
            {
                Console.WriteLine($"{cnt} record(s) updated");
            }
            else
            {
                Console.WriteLine("No employee found with that Id");
            }

            connection.Close();
        }

        public void DeleteEmployee()
        {
            Console.WriteLine("Prompt:");
            Console.WriteLine("Enter Employee Id:");
            int id = int.Parse(Console.ReadLine());

            string query = $"DELETE FROM Employees WHERE EmployeeId={id}";
            connection = new SqlConnection(conStr);
            connection.Open();
            Console.WriteLine("Connection Opened");

            cmd = new SqlCommand(query, connection);
            int cnt = cmd.ExecuteNonQuery();

            if (cnt > 0)
            {
                Console.WriteLine($"{cnt} record(s) deleted");
            }
            else
            {
                Console.WriteLine("No employee found with that Id");
            }

            connection.Close();
        }
    }
}
