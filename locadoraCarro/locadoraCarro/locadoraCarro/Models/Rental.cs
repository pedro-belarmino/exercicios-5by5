using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using locadoraCarro.abstracts;

namespace locadoraCarro.Models
{
    public class Rental
    {
        private Person Customer {  get; set; }
        private Vehicle Vehicle { get; set; }

        private DateTime RentalDate { get; set; } = DateTime.Now;
        private DateTime? ReturnDate { get; set; } = null;
        private double? TotalPrice { get; set; } = null;

        public Rental(Person c, Vehicle v) {
        this.Vehicle = v;
        this.Customer = c;
        }
    }
}
