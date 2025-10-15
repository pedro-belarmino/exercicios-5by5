using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Endereco
    {
        public string Logradouro { get; set; }
        public int? Number { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string? Complement { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public Endereco(
            string logradouro,
            int? number,
            string bairro,
            string CEP,
            string? complement,
            string cidade,
            string estado,
            string pais
            )
        {
            this.Logradouro = logradouro;
            this.Number = number;
            this.Bairro = bairro;
            this.CEP = CEP;
            this.Complement = complement;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;
        }
    }



}
