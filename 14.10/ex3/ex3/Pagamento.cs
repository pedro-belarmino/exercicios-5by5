using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Pagamento
    {
        double Valor;
        string DataPagamento;


        public void setValor(double valor) { Valor = valor; }
        public double getValor() { return Valor; }

        public void setDataPagamento(string dataPagamento) { DataPagamento = dataPagamento; }
        public string getDataPagamento() { return DataPagamento; }

        public virtual void ProcessarPagamento()
        {
            
            Console.WriteLine("Insira o valor do pagamento");
            Valor = double.Parse(Console.ReadLine());
        }
    }
}
