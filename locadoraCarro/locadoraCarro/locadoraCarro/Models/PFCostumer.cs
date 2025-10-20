using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using locadoraCarro.abstracts;

namespace locadoraCarro.Models
{
    public class PFCostumer : Person
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        private string CNH { get; set; }
        private string CPF { get; set; }
        public PFCostumer(
            string n,
            DateOnly b,
            Contact c,
            Address a,
            string CNH,
            string CPF
            )
            : base(n, b, c, a)
        {
            this.CNH = CNH;
            this.CPF = CPF;
        }


        public override string ToString()
        {
            return $"{base.ToString()}\nCNH: {this.CNH}";
        }




    }
}