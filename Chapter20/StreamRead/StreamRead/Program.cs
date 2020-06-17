using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace StreamRead
{
    class Program
    {
        static void Main() // removed string[] args
        {
            string line;

            try
            {
                FileStream aFile = new FileStream("../../Log.txt", FileMode.Open);  //Changed relative path to ../../ so it puts it in same folder as Program.cs
                StreamReader sr = new StreamReader(aFile);
                line = sr.ReadLine();
                // Read data in line by line.
                while (line != null) // null exception added in case there is no line to read, aka EOF.
                {
                    WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (IOException e)
            {
                WriteLine("An IO exception has been thrown!");
                WriteLine(e.ToString());
                //return;
            }
            ReadKey();
        }
    }
}