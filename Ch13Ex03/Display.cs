using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch13Ex03
{
    public class Display
    {
        public void DisplayMessage(object source, MessageArrivedEventArgs e) // This is an Anonymous method, page 375
            // variables created in anonymous methods may require a non-default deconstructor due to how long they can hang around as an OUTER VARIABLE.
        {
            WriteLine($"Message arrived from: {((Connection)source).Name}");
            WriteLine($"Message Text: {e.Message}");
        }
    }
}