using System.Collections.Generic;
using System.IO;

class Assignment4
{
    public void CreateFileAndFolders()
    {
        string rootFolderPath = "E:/Test/Root";
        for (int i = 1; i <= 10; i++)
        {
            var folderPath= $"{rootFolderPath}/Folder{i}";

            List<string> fileInfos = new List<string>();

            Directory.CreateDirectory(folderPath);

            var filePath = $"{folderPath}/file{i}.txt";
            /* File.WriteAllText(filePath); */

            FileInfo fileinfo = new(filePath);
            string info =$"Created Date :{fileinfo.CreationTime}\n"+
            $"Last Modified :{fileinfo.LastWriteTime} \n"+
            $"File Size : {(float)fileinfo.Length/ 1024}\n"+
            $"file Type :{fileinfo.Extension}" ;
            fileInfos.Add(info);

            File.AppendAllText(filePath, info);
        }
    }
}

