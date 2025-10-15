using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class PJEmployee : Employee
    {
        private int WorkedHours;
        private double ValueHours;
        public override double CalculateFinalSalary()
        {
            return this.WorkedHours + this.ValueHours;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Horas Trabalhadas " + this.WorkedHours);
            Console.WriteLine("Valor Hora:" + ValueHours);
            Console.WriteLine("Salario Total: " + this.CalculateFinalSalary());
        }

        public void setWorkedHours(int value)
        {
            WorkedHours = value;
        }
        public double getWorkedHours()
        {
            return WorkedHours;
        }

        public void setValueHours(double value)
        {
            this.ValueHours = value;
        }
        public double getValueHours()
        {
            return this.ValueHours;
        }

    }
}

