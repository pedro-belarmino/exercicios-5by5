namespace POO
{
    public class Pessoa
    {
        public int Idade;
        public string Nome;
        public string CPF;
        public double Altura;

        public Pessoa()
        {

        }

        public void setIdade(int idade)
        {
            this.Idade = idade;
        }
        public int getIdade()
        {
            return this.Idade;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public string getNome()
        {
            return this.Nome ;
        }

        public void setCPF(string cpf)
        {
            this.CPF = cpf;
        }
        public string getCPF()
        {
            return this.CPF;
        }

        public void setAltura(double altura)
        {
            this.Altura = altura;
        }
        public double getAltura()
        {
            return (double) this.Altura;
        }

    }
}