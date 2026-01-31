using System;
using System.Collections;
using System.Globalization;
using System.Text;

class Program
{
    public static void Main()
    {

        ArrayList obj = new ArrayList();
        Employee emp1 = new Employee { Id = 10, Name = "Suresh" };
        Employee emp2 = new Employee { Id = 20, Name = "Ramesh" };
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(emp1);
        list.Add(emp2);
        Console.WriteLine($"Count of array list: {list.Count}");

        // foreach (var item in list)
        // {
        //     Console.WriteLine(item);
        // }

        obj.AddRange(list);
        foreach (var item in obj)
        {
            Console.WriteLine(item);
        }


        obj.Clear();
        Console.WriteLine($"Count of array list: {obj.Count}");

        foreach (var item in obj) // empty
        {
            Console.WriteLine(item);
        }

        if (list.Contains(10))
        {
            Console.WriteLine($"Object 50 is at index no: {list.IndexOf(10)}");
        }
        else
        {
            Console.WriteLine($"Object not found");
        }

        list.RemoveAt(0);
        Console.WriteLine("\n\n List after Removing value at index 0");
        foreach (var item in list) // empty
        {
            Console.WriteLine(item);
        }

        list.RemoveRange(0, 1);
        Console.WriteLine("\n\n List after Removing value in range");
        foreach (var item in list) // empty
        {
            Console.WriteLine(item);
        }

        list.Add(10);
        list.Add(20);
        list.Add(30);
        Console.WriteLine("\n\n List before Sorting:");
        foreach (var item in list) // empty
        {
            Console.WriteLine(item);
        }

        // list.Sort();
        Console.WriteLine("\n\n List After Sorting:");
        foreach (var item in list) // empty
        {
            Console.WriteLine(item);
        }

        // reverse
        list.Reverse();
        // Insert
        list.Insert(0, 90);
        Console.WriteLine("\n\n List Reverse + insert Sorting:");
        foreach (var item in list) // empty
        {
            Console.WriteLine(item);
        }







        /* -----------------------------------------------------------------*/
        // StringBuilder sb1 = new StringBuilder("Hello World");
        // for(int i = 0; i < sb1.Length; i++)
        // Console.WriteLine(sb1[i]);

        // StringBuilder sb = new StringBuilder();
        // sb.AppendLine("World!");
        // sb.Append("Hello ");
        // sb.AppendLine("World!!");
        // sb.AppendLine("Hello C#");
        // Console.WriteLine($"Updated word: {sb}");

        // StringBuilder sbAmount = new StringBuilder("Your total amount is:");
        // sbAmount.AppendFormat("{0:C},{1:C} ",25,35);
        // Console.WriteLine($"sbAmount:{sbAmount}");

        // CultureInfo india = new CultureInfo("en-IN");
        // sbAmount.AppendFormat(india, "{0:C}", 12211284);
        // Console.WriteLine($"sbAmount currency: {sbAmount}");
    }
}