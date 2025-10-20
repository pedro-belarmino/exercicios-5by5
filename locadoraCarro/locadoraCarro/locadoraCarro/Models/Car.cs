using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using locadoraCarro.abstracts;

namespace locadoraCarro.Models
{
    public class Car : Vehicle
    {
        private bool ManualGearbox { get; set; }
        private int NumberOfPassangers { get; set; }


        public Car(
            string m,
            string b,
            string l,
            Kind k,
            string c,
            int y,
            bool a,
            double d,
            bool manualGearbox,
            int numberOfPassangers) : base(m, b, l, k, c, y, a, d)
        {
            this.ManualGearbox = manualGearbox;
            this.NumberOfPassangers = numberOfPassangers;
        }
    }
}
