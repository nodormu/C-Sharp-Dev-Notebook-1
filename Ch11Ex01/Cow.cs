using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex01
{
    public class Cow : Animal  //Animal.name does NOT work. You must inherit. because its OOP. In the first several chapters I was able to reference things, but only public.
    {
        public void Milk() => WriteLine($"{name} has been milked.");  // You can't do Animal.name because of it's protection level, it can only be inherited via the class becuase its OOP.
        public Cow(string newName) : base(newName) { } // See line 32 in Main for this instanciation:  Cow myCow2 = new Cow("Donna");
    }
}