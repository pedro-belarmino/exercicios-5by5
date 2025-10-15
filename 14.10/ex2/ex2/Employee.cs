using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public abstract class Employee
    {
        private string Name; //private pra 'encapsular'
        private double BaseSalary;

        public abstract double CalculateFinalSalary();

        public virtual void ShowInfo()
        {
            Console.WriteLine("Nome: " + this.Name);
            Console.WriteLine("Salario Base: " + this.BaseSalary);
        }

        public void setNome(string name)
        {
            this.Name = name;
        }
        public string getNome()
        {
            return this.Name;
        }
        public void setBaseSalary(double salary)
        {
            this.BaseSalary = salary;
        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
    }
}
