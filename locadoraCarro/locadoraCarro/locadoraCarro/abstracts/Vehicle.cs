using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraCarro.abstracts
{
    public abstract class Vehicle
    {
        private Guid Id {  get; set; }
        private string Model { get; set; }
        private string Brand { get; set; }
        private string LicensePlate { get; set; }
        private Kind Kind { get; set; }
        private string Color { get; set; }
        private int Year { get; set; }
        private bool isAvaliable { get; set; } = true;
        private double DailyCost { get; set; }

        protected Vehicle(
            string m,
            string b,
            string l,
            Kind k,
            string c,
            int y,
            bool a,
            double d
            )
        {
            Model = m;
            Brand = b;
            LicensePlate = l;
            Kind = k;
            Color = c;
            Year = y;
            isAvaliable = a;
            DailyCost = d;

        }
    }
}