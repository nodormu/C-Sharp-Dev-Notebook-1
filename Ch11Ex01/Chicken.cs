using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex01
{
    public class Chicken : Animal  //Animal.name does NOT work. You must inherit, because it's OOP. In the first several chapters, I was able to reference things this way, but only public.
    {
        public void LayEgg() => WriteLine($"{name} has laid an egg.");  // You can't do Animal.name because of it's protection level, it can only be inherited via the class because it's OOP.
        public Chicken(string newName) : base(newName) { }
    }
}
