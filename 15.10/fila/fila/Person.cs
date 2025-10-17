using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Person
    {
        public string Name { get; set; }
        public Person Next { get; set; }
    
        public void setName(string name)
        {
            Name = name;
        }
    public Person() {
            this.Next = null;
        }
    }
}
