using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            //helper.InsertDepartment();
            //helper.InsertEmployee();
            //helper.SelectAllDepartments();
            //helper.SelectAllEmployees();
            //helper.SelectEmployeesWithDepartment();
            //helper.UpdateEmployeeSalary();
            helper.DeleteEmployee();
        }
    }
}
