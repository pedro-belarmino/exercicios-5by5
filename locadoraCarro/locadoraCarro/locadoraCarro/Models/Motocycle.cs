using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using locadoraCarro.abstracts;

namespace locadoraCarro.Models
{
    public class Motocycle : Vehicle
    {
        private int CylinderCapacity {  get; set; }
        private int NumberOfPassangers { get; set; }
        public Motocycle(
            string m,
            string b,
            string l, 
            Kind k,
            string c,
            int y, 
            bool a,
            double d,
            int cylinder,
            int passangers
            ) : base(m, b, l, k, c, y, a, d)
        {
            this.CylinderCapacity = cylinder;
            this.NumberOfPassangers = passangers;
        }

    }
}