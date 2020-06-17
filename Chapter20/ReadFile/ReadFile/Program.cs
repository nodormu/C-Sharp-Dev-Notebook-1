using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace ReadFile
{
    class Program
    {
        static void Main() // removed string[] args from Main(), If you left it in, you could add a null statement for the args
        {
            // 967 was chosen through trial and error, but a Rebuild all was necessary for the code to compile correctly, because 800 worked initially.
            byte[] byteData = new byte[967];  // Changed size from 200 to 967 to accomodate entire contents of file
            char[] charData = new char[967];  // Changed size from 200 to 967 to accomodate entire contents of file

            try
            {
                FileStream aFile = new FileStream("../../2017-ExtensionsUpdates.txt", FileMode.Open);  // Instead of reading Program.cs, I added a file to same directory to read instead.
                aFile.Seek(0, SeekOrigin.Begin); // changed 174 to 0 so it would read from beginning of file.
                aFile.Read(byteData, 0, 967);  // changed amount to be read from 200 to 967 so it would read all contents of file.
            }
            catch (IOException e)
            {
                WriteLine("An IO exception has been thrown!");
                WriteLine(e.ToString());
                ReadKey();
                return;
            }

            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(byteData, 0, byteData.Length, charData, 0);

            WriteLine(charData);
            ReadKey();
        }
    }
}