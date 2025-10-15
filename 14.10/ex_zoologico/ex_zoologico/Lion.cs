using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_zoologico
{
    internal class Lion : Animal
    {
        public override string MakeSound()
        {
            return "RRRRRRRROOOOOOOOOOAAAAAAAAAARRRRRRRR";
        }
        public Lion(string name, int ange) : base(name, ange)
        {
        }
    }
}
