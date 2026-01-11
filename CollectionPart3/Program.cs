// Added using directives for collections
using System;
using System.Collections.Generic;
using System.Collections;
class Program
{
    // Made list static to allow access from static methods
    static LinkedList<string> list = new LinkedList<string>();

    public static void Main()
    {
        // Restructured loop to read choice inside the loop and handle exit properly
        while (true)
        {
            Console.WriteLine("Enter Choice:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete ");
            Console.WriteLine("5. Clear");
            Console.WriteLine("Type 'Exit' to quit");

            string choice = Console.ReadLine();

            if (choice == "Exit") break;

            switch (choice)
            {
                case "1":
                case "Add":
                    AddStudent();
                    break;

                case "2":
                case "Display":
                    DisplayStudent();
                    break;

                case "3":
                case "Update":
                    UpdateStudent();
                    break;

                case "4":
                case "Delete":
                    DeleteStudent();
                    break;

                case "5":
                case "Clear":
                    ClearStudent();
                    break;

                default:
                    Console.WriteLine("Invalid Choice:");
                    break;
            }
        }
    }



    public static void AddStudent()
    {
        // Added prompt for user input
        Console.Write("Enter name to add: ");
        string name = Console.ReadLine();
        list.AddLast(name);
    }

    public static void UpdateStudent()
    {
        // Removed parameter, added prompts, fixed logic to check oldName and update if found
        Console.Write("Enter old name: ");
        string oldName = Console.ReadLine();
        if (list.Contains(oldName))
        {
            Console.Write("Enter new name: ");
            string newName = Console.ReadLine();
            LinkedListNode<string> current = list.First;

            while (current != null)
            {
                if (current.Value == oldName)
                {
                    current.Value = newName;
                    Console.WriteLine("Name updated successfully");
                    break;
                }
                current = current.Next;
            }
        }
        else
        {
            Console.WriteLine("Name not found");
        }
    }

    public static void DeleteStudent()
    {
        // Added prompt for user input
        Console.Write("Enter name to delete: ");
        string name = Console.ReadLine();
        if (list.Contains(name))
        {
            list.Remove(name);
            Console.WriteLine("Element removed successfully");
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }

    public static void ClearStudent()
    {
        list.Clear();
        // Fixed typo: 'lsit' to 'list'
        Console.WriteLine("all linked list elements cleared successfully");
    }

    public static void DisplayStudent()
    {
        if (list.Count != 0)
        {
            Console.WriteLine("Linked list elements are:");
            foreach (var elem in list)
            {
                Console.WriteLine(elem);
            }
        }
        else
        {
            Console.WriteLine("No elements are present");
        }
    }

}


