using System;
using System.IO;

class MainClass
{
    public static void Main(string[] args)
    {
        string basePath = "C:\\";
        while (true)
        {
            string folderName = Path.GetRandomFileName();
            string folderPath = Path.Combine(basePath, folderName);
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Created folder: " + folderPath);
        }
    }
}
