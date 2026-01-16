

// class Program
// {
//     public static void Main()
//     {
//         string[] names = { "Bill", "Steve", "James", "Mohan" };
//            // write the query
//            var name = from s in names       //query syntax
//                        where s.Contains('a')
//                        select s; 
//             // execute the query
//             foreach(string s in name)
//             {
//                 Console.WriteLine(s);
//             } 


//         //*******************************************************************//

//         var name1 = names.Where(s => s.Contains('a')); // Method syntax
//         foreach (string s in name1)
//         {
//             Console.WriteLine(s);
//         }
//     }
// }