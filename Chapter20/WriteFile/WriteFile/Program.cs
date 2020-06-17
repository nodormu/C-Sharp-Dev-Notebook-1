using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace WriteFile
{
    class Program
    {
        static void Main() // removed string[] args
        {
            byte[] byteData;
            char[] charData;

            try
            {
                FileStream aFile = new FileStream("../../Temp.txt", FileMode.Create);  // Changed relative path of Temp.txt to ../../Temp.txt so it would be in same directory as Program.cs
                charData = "Instead of Encoder e, I changed it to Encoder f.".ToCharArray();
                byteData = new byte[charData.Length];
                Encoder f = Encoding.UTF8.GetEncoder(); // Encodes character array into bytearray. f is just a variable. could be anything.
                f.GetBytes(charData, 0, charData.Length, byteData, 0, true); // this converts the character array to the byte array so the FileStream() object can use it.

                // Move file pointer to beginning of file.
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Write(byteData, 0, byteData.Length);
                ReadKey();
            }
            catch (IOException ex)
            {
                WriteLine("An IO exception has been thrown!");
                WriteLine(ex.ToString());
                ReadKey();
                return;
            }
        }
    }
}