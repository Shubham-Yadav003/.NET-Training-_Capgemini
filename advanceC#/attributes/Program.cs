// Rectangle rectangle = new Rectangle(20,30);
// rectangle.GetArea();
// rectangle.Display();

using System;
using System.Reflection;
public class Program
{
    public static void Main()
    {
        Assembly executing = Assembly.GetExecutingAssembly();
        Type[] types = executing.GetTypes();
        foreach(var item in types)
        {
            //display each type
            Console.WriteLine("Type: " + item.Name);
            //array to store methods of each type
            MethodInfo[] methods = item.GetMethods();
            foreach(var method in methods)
            {
                //display each method
                Console.WriteLine("\tMethod: " + method.Name);
                //array to store parameters of each method
                ParameterInfo[] parameters = method.GetParameters();
                foreach(var parameter in parameters)
                {
                    //display each parameter
                    Console.WriteLine($"\t\tParameter: {parameter.Name} Type: {parameter.ParameterType}");
                }
            }
        }


        //Initilize t as typeof string
        Type t = typeof(string);

        Console.WriteLine($"Name: {t.Name}");
        Console.WriteLine($"Namespace: {t.Namespace}");
        Console.WriteLine($"Full Name: {t.FullName}");
        Console.WriteLine($"Base Type: {t.BaseType}");


        Student student = new Student("Alice", 101);
        student.DisplayInfo();

        Type type = typeof(Student);
        Console.WriteLine("Class Name: " + type.Name);

        MethodInfo methodInfo = type.GetMethod("DisplayInfo");
        Console.WriteLine("Method Name: " + methodInfo.Name);
    }
}