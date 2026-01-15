using System.IO;
class Program
{
    static string filePath = "temp.txt";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Application Error Logger ---");
            Console.WriteLine("1. Log Error");
            Console.WriteLine("2. View Errors");
            Console.WriteLine("3. Clear Log");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LogError();
                        break;

                    case 2:
                        ViewErrors();
                        break;

                    case 3:
                        ClearLog();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                    break;
                }
            }

            catch (Exception ex)
            {
              Console.WriteLine("Error: " + ex.Message);      
            }
        }
    }

    static void LogError()
    {
        try
        {
          FileStream  fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
          StreamWriter streamWriter = new StreamWriter(fileStream);
          Console.Write("Enter Error Message:");
          string errorMsg = Console.ReadLine();

          string logEntry = $"{DateTime.Now}: {errorMsg}";
          streamWriter.WriteLine(logEntry);
          streamWriter.Close();
          fileStream.Close();
          Console.WriteLine("Error Logged Successfully"); 
        }

        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void ViewErrors()
    {
        if (File.Exists(filePath))
        {
            string[] logEnteries = File.ReadAllLines(filePath);
            Console.WriteLine("Error Log");
            foreach(string entry in logEnteries)
            {
                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine("No error log found");
        } 
    }

    public static void ClearLog()
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Console.WriteLine("Error log cleared");
        }
        else
        {
            Console.WriteLine("No error log found to clear");
        }
    }
}
