using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ex_zoologico
{
    internal class Cat : Animal
    {
        public override string MakeSound()
        {
            return "MIAAAAAAAAUUUU";
        }
        public Cat(string name, int age) : base(name, age) { }
    }
}
