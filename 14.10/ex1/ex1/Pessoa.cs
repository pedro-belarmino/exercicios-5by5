using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public int Idade;
        public double Altura;
        public string Sexo;

    public void setNome(string nome)
        {
            this.Nome = nome;
        }
    public string getNome()
        {
            return this.Nome;
        }

    public void setSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }
    public string getSobrenome()
        {
            return this.Sobrenome;
        }

    public void setIdade(int idade)
        {
            this.Idade = idade;
        }
    public int getIdade()
        {
            return this.Idade;
        }

    public void setAltura(double altura)
        {
            this.Altura = altura;
        }
    public double getAltura()
        {
            return this.Altura;
        }

    public void setSexo(string sexo)
        {
            this.Sexo = sexo;
        }
    public string getSexo()
        {
            return this.Sexo;
        }


    public void showPessoas()
        {
            Console.WriteLine($"{getNome} {getSobrenome}");
            Console.WriteLine(getIdade);
            Console.WriteLine(getAltura);
            Console.WriteLine(getSexo);
        }


    }
}
