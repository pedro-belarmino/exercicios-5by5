using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_zoologico
{
    internal class Dog : Animal
    {

        public override string MakeSound()
        {
            return "AUAU";
        }
public Dog(string name, int age) : base(name, age) { }
    }
}

