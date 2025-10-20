using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using locadoraCarro.abstracts;

namespace locadoraCarro.Models
{
    public class Truck : Vehicle
    {


        private int LoadCapacity {  get; set; }
        private int Axles { get; set; }

        public Truck(
            string m,
            string b, 
            string l,
            Kind k, 
            string c, 
            int y, 
            bool a,
            double d,
            int load,
            int axles
            ) : base(m, b, l, k, c, y, a, d)
        {
            LoadCapacity = load;
            Axles = axles;
        }

    }
}
