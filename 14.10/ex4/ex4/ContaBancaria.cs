using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class ContaBancaria
    {
        private double Saldo;
        private string Titular;
        public void setSaldo(double saldo) { this.Saldo = saldo; }
        public double getSaldo() { return this.Saldo; }

        public void setTitular(string titular) { this.Titular = titular; }
        public string getTitular() { return this.Titular; }

        public void Depositar(double value)
        {
            this.Saldo += value;
        }
        public void Sacar(double value)
        {
            if(value >= Saldo)
            {
                Console.WriteLine("Insira um valor menor do que o seu salvo.");
                return;
            } else
            {
                this.Saldo -= value;
            }
        }
    }

}
