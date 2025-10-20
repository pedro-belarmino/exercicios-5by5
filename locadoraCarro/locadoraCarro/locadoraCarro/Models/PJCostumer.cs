using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using locadoraCarro.abstracts;

namespace locadoraCarro.Models
{
    public class PJCostumer : Person
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        private string CNPJ { get; set; }

        public PJCostumer(
        string n,
        DateOnly b,
        Contact c,
        Address a,
        string cnpj
        )
        : base(n, b, c, a)
        {
            CNPJ = cnpj;
        }


        public override string ToString()
        {
            return $"{base.ToString()}\nCNPJ: {this.CNPJ}";
        }

    }
}