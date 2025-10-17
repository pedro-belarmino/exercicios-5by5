using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaPrioridade
{
    internal class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public bool Priority {  get; set; }
        public Person Next { get; set; }

        //public void setName(string name)
        //{
        //    this.Name = name;
        //}
        //public void setAge(int age)
        //{
        //    this.Age = age;
        //}
        //public void setPriority(bool priority)
        //{
        //    this.Priority = priority;
        //}

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            
            this.Next = null;

            if(this.Age > 59)
            {
                Priority = true;
            } else
            {
                Priority = false;
            }


        }
    }
}
