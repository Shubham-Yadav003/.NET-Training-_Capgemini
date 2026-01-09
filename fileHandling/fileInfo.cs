using System;
using System.IO;
class FileInfoDemo
{
    public static void Main()
    {
        // string path = @"info.txt";
        // FileInfo f1 = new FileInfo(path);
        // File.Create(path);

        // Console.WriteLine("File has been created");

        // this method creates a streamwriter that writes a new text file
        // FileInfo fi = new FileInfo(@"infoWriter.txt");
        // StreamWriter str = fi.CreateText();
        // str.WriteLine("hello");
        // str.WriteLine("hello hii");
        // str.WriteLine("hello bye");
        // str.Close();

        // for deleting
        //  FileInfo fi = new FileInfo($"infoWriter.txt"); // cool
        //  fi.Delete();
        //  Console.WriteLine("file ahs been deleted");

        // string path1 = @"file1.txt";
        // string path2 = @"file2.txt";
        // FileInfo fil1 = new FileInfo(path1);
        // FileInfo fil2 = new FileInfo(path2);
        // fil1.CopyTo(path2);
        // Console.WriteLine("path1 copied to path2");


        // move to
        // string path = @"file1.txt";
        // string path2 = @"file2.txt";

        // FileInfo fil1 = new FileInfo(path);
        // FileInfo fil2 = new FileInfo(path2);

        // fil1.MoveTo(path2);
        // Console.WriteLine("File 1 moved to file  2");


        //append method to create stream writer tht appends
        // FileInfo fi = new FileInfo(@"temp.txt");
        // StreamWriter sw = fi.AppendText();
        // sw.Write("holla amigo");
        // sw.Write("kaysa ho thik ho?");
        // Console.WriteLine("File has been appended");
        // sw.Close();




        // this method creates a StreamReader with utf8 encoding that reads from existing file
        // FileInfo fi = new FileInfo(@"temp.txt");
        // StreamReader sr = fi.OpenText();
        // string s = "";
        // while ((s = sr.ReadLine()) != null)
        // {
        //     Console.WriteLine(s);
        // }


        FileInfo fi = new FileInfo(@"temp.txt");
        Console.WriteLine("File name is:{0}", fi.Name);
        Console.WriteLine("File Creation time is:{0}", fi.CreationTime.ToLongTimeString());
        Console.WriteLine("File last access is:{0}", fi.LastAccessTime.ToLongDateString());
        Console.WriteLine("File length is:{0}", fi.Length.ToString() + " bytes");
        Console.WriteLine("File extension is:{0}", fi.Extension);
        Console.WriteLine("File exist is:{0}", fi.Exists);



    }
}