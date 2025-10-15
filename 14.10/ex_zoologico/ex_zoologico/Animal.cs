using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_zoologico
{
    public abstract class Animal
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public string GetName() { return this.Name; }
        public int GetAge() { return this.Age; }
    
    public Animal(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
    public override string ToString()
        {
            return $"Nome: {this.Name} Idade: {this.Age}";
        }
        public abstract string MakeSound();
    
    
    
    
    
    }
}
