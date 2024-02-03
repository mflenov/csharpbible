using System;
using System.IO;


namespace DirFileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFiles("C:\\");
        }

        static void GetFiles(string path)
        {
            foreach (string dir in Directory.GetDirectories(path))
            {
                if ((File.GetAttributes(dir) & FileAttributes.Hidden) == FileAttributes.Hidden)
                    continue;

                string dirname = System.IO.Path.GetFileName(dir);
                Console.WriteLine(dirname.ToUpperInvariant());
            }

            foreach (string file in Directory.GetFiles(path))
            {
                string filename = System.IO.Path.GetFileName(file);
                Console.WriteLine(filename.ToLowerInvariant());
            }
        }
    }
}
