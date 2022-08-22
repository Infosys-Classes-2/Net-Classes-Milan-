using System;
using System.IO;

public class FileIO
{
    public void Do()
    {
        string folderPath = @"E:\Test\test1.cs";

        // Creating Directory
        Directory.CreateDirectory(@"E:\Test\Test1");

        /// Creating and REading the file
        File.AppendAllText(folderPath, "I an a goood Boyyyyy");
        Console.WriteLine("The File IS Created");

        //reading file
        var text = File.ReadAllText(folderPath);
        Console.WriteLine("File content:" + text);

        //Printing Details of Files

        FileInfo fileInfo = new(folderPath);
        Console.Write("file Details");
        Console.WriteLine("created Date:" + fileInfo.CreationTime);
        Console.WriteLine("Name of File:"+ fileInfo.Name);
        Console.WriteLine("Last Updated:"+ fileInfo.LastWriteTime);

    }
}
