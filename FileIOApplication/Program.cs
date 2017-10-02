using System;
using System.IO;

namespace FileIOApplication
{
    // Stream: A file is a collection of data stored in a disk with a specific 
    // name and a directory path. When a file is opened for reading or writing, 
    // it becomes a stream.

    // The stream is basically the sequence of bytes passing through the communication
    // path. There are two main streams: the input stream and output stream. The input
    // stream is used for reading data from file (read operation) and the output stream
    // is used for writing into the file (write operation).

    // Example of creating a FileStream object F
    // FileStream F = new FileStream("sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

    // FileMode: this enumerator defines various methods for opening files. It has members: Append,
    // Create, CreateNew, Open, OpenOrCreate, Truncate.
    // FileAccess: this enumerator has members: Read, ReadWrite and Write.
    // FileShare: this enumerator has members: Inheritable, None, Read, ReadWrite, Write.
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}
