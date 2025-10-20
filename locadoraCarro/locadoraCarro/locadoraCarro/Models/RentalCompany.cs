﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using locadoraCarro.abstracts;

namespace locadoraCarro.Models
{
    public class RentalCompany
    {
        public List<Person> Customers = new List<Person>();
        public List<Vehicle> Vehicles = new List<Vehicle>();
        public List<Rental> Rentals = new List<Rental>();
    }
}
