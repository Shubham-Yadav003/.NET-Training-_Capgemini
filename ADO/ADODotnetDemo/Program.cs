using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODotnetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectedEnvDemo obj = new ConnectedEnvDemo();
            //obj.GetAllStudent();
            //obj.GetStudentById(2);
            //obj.GetStudentByCourseName("Physics");
            //obj.AddNewStudent(55, "shubh", "Chemistry", 87);
            //obj.UpdateStudent(7,"shubham_yadav","Arts",99, 55);
            //obj.Delete(7);



            DisconnectEnvDemo obj2 = new DisconnectEnvDemo();
            //obj2.GetAllStudent();
            obj2.AddNewStudent();
            Console.ReadKey();
        }
    }
}
