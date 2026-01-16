// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// using System ;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         IList<Person> personList = new List<Person>()
//         {
//             new Person{ Name = "Kundan", Age = 25, BodyCount = 70 },
//             new Person{ Name = "Gaurav", Age = 30, BodyCount = 80 },
//             new Person{ Name = "Krishna", Age = 22, BodyCount = 75 },
//             new Person{ Name = "Shubham", Age = 28, BodyCount = 85 },
//             new Person{ Name = "Sunny Leon", Age = 35, BodyCount = 90 }
            
//         };

//         // Write The Query (Linq Query Syntax)
//         var result = from person in personList
//                      where person.BodyCount > 75
//                      select person;

//         // Execute The Query
//         foreach (var item in result)
//         {
//             Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
//         }

        
//     }
// }