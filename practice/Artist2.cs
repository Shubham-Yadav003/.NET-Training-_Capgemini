using System;
using System.Collections;
public class Artist2
{
    private static ArrayList albums = new ArrayList();

    private static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add Album");
            Console.WriteLine("2. View Album");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddAlbum();
                    break;

                case "2":
                    DisplayAlbum();
                    break;

                case "3":
                    running = false;
                    Console.WriteLine("Exiting Program");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }

        }
    }

    private static void AddAlbum()
    {
        Console.WriteLine("Enter Album Title:");
        string title = Console.ReadLine();

        Console.WriteLine("Enter Artist Name:");
        string artist = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(artist))
        {
            Console.WriteLine("title and artist can not be empty");
            return;
        }

        Artist obj = new Artist(artist, title);

        albums.Add(obj);
        Console.WriteLine("Element added successfully");

    }

    private static void DisplayAlbum()
    {
        if (albums.Count == 0)
        {
            Console.WriteLine("No albums available");
            return;
        }

        Console.WriteLine("Album list");
        for (int i = 0; i < albums.Count; i++)
        {
            Artist abc = (Artist)albums[i];
            Console.WriteLine($"{i + 1} Title: {abc.Title_name}, Artist: {abc.Artist_name}");
        }
    }
}