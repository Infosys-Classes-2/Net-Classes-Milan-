using System;
using System.IO;

class Assignment4ClassWork{

    public void Display(){
        string folderPath = @"D:";

        var files =Directory.EnumerateDirectories(folderPath);
        var folders= Directory.EnumerateFiles(folderPath);

        string infoTable = "File/Folder Name \t\t Created Date \t\t Size \t\t Is File \n";

        foreach (var file in files)
        {
            FileInfo fi = new(file);
            var fileInfo = $"{fi.Name}\t\t{fi.CreationTime}\t\t{fi.Length}\t\t True\n";
            infoTable += fileInfo;   
        }
        Console.WriteLine(infoTable);
    }
}