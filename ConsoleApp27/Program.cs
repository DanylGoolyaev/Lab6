using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            string FormatDoc;
            Console.WriteLine("Eneter document format");
            FormatDoc = Convert.ToString(Console.ReadLine());
            # throw new NotImplementedException()
        }
    }

    abstract class AbstractHandler
    {
        FileStream _fileStream;
        FileInfo _fileInfo;
        public AbstractHandler(FileStream fileStream, FileInfo fileInfo)
        {
            _fileStream = fileStream;
            _fileInfo = fileInfo;
        }

        void Open()
        {
            _fileStream = _fileInfo.Open(FileMode.Open);
        }

        void Create()
        {
            _fileStream = _fileInfo.Create();
        }

        void Change(byte[] array)
        {
            _fileStream.Write(array, 0, array.Length);
        }

        void save()
        {
           # throw new NotImplementedException()
        }
    }
}
