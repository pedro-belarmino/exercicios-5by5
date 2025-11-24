using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosArquivo
{
    public class Locadora
    {
        public List<Carro> carros { get; }


        public Locadora(List<Carro> c)
        {
            this.carros = c; //pega a lista recebida e joga para a lista da classe
        }

        Random num = new Random();
        public void CadastrarCarro()
        {
            var id = num.Next(1000);
            Console.WriteLine("Marca ");
            var marca = Console.ReadLine();
            Console.WriteLine("Modelo ");
            var modelo = Console.ReadLine();
            Console.WriteLine("Ano ");
            var ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Cor ");
            var cor = Console.ReadLine();
            Console.WriteLine("Placa ");
            var placa = Console.ReadLine();

            this.carros.Add(new Carro(id, marca, modelo, ano, cor, placa));
        }

        public void ListarTodosCarros()
        {
            foreach (var c in this.carros)
            {
                Console.WriteLine(c + "\n");
            }
        }

        private Carro BuscarCarro(int id)
        {
            return this.carros.Find(c => c.Id == id);
        }

        public void AtualizarCarro()
        {
            foreach (var c in this.carros)
            {
                Console.WriteLine($"{c.Id} - Modelo\n");
            }
            Console.WriteLine("\nQual id do carro");
            var id = int.Parse(Console.ReadLine());
            var carro = BuscarCarro(id);
            if (carro == null)
            {
                Console.WriteLine("Carro não encontrado");
            }
            else
            {
                Console.WriteLine("Qual a nova cor do carro");
                var nc = Console.ReadLine();
                carro.setCor(nc);

                Console.WriteLine(carro);
            }
        }

        public void RemoverCarro()
        {
            foreach (var c in this.carros)
            {
                Console.WriteLine($"{c.Id} - Modelo\n");
            }
            Console.WriteLine("\nqual id");

            var id = int.Parse(Console.ReadLine());
            var carro = BuscarCarro(id);

            if (carro == null)
            {
                Console.WriteLine("carro não encontrado");
            }
            else
            {
                this.carros.Remove(carro);
                Console.WriteLine("carro removido\n\n");

                Console.WriteLine(carro);
            }
        }
    }
}