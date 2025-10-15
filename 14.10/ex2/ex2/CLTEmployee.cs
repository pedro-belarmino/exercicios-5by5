using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class CLTEmployee : Employee
    {
        private double Bonus;
        public override double CalculateFinalSalary()
        {
            return this.getBaseSalary() + this.Bonus;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Bonus" + this.Bonus);
            Console.WriteLine("Salario Total " + this.CalculateFinalSalary());
        }

        public void setBonus(double value)
        {
            this.Bonus = value;
        }
        public double getBonus()
        {
            return this.Bonus;
        }

    }
}
