using System;
using System.IO;
using System.Text;

namespace MemoryStreamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const string STRING_EXAMPLE = "Эту строку поместим в память";

            UnicodeEncoding unicode = new UnicodeEncoding();
            byte[] str = unicode.GetBytes(STRING_EXAMPLE);
            int string_size = unicode.GetByteCount(STRING_EXAMPLE);

            MemoryStream ms = new MemoryStream(string_size);
            ms.Write(str, 0, string_size);
            ms.Seek(0, SeekOrigin.Begin);

            byte[] buffer = new byte[string_size];
            ms.Read(buffer, 0, string_size);
            Console.WriteLine(unicode.GetString(buffer));
        }
    }
}
