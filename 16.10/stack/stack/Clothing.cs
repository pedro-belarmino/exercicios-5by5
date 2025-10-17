using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Clothing
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Clothing Next { get; set; }

        public Clothing(string n, string d)
        {
            Name = n;
            Description = d;

            this.Next = null;
        }

        public void setName(string n)
        {
            this.Name = n;
        }
        public void setDescription(string d)
        {
            this.Description = d;
        }

        public override string ToString()
        {
            return $"{Name} - {Description}";

        }
    }
}