using System;
using System.IO;
namespace Q8._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F://Steam";
            if (!File.Exists(filePath))
            {
                try
                {
                    var directory = new DirectoryInfo(filePath);
                    Console.WriteLine("Размер в байтах:{0}",DirectorySize.DirSize(directory));
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    public static class DirectorySize
    {
        public static long DirSize (DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] files = d.GetFiles();
            foreach(FileInfo fi in files)
            {
                size += fi.Length;
            }
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);

            }
            return size;
        }
    }
}
