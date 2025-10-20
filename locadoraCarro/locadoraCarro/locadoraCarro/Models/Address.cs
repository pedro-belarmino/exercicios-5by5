﻿namespace locadoraCarro.Models
{
    public class Address
    {
        private string Street { get; set; }
        private int Number { get; set; }
        private string Neighborhood { get; set; } = String.Empty;
        private string ZipCode { get; set; }
        private string? Complement { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string Country { get; set; } = string.Empty;
        public Address(string street,
            int number, string neighborhood,
            string zipCode, string? complement,
            string city, string state,
            string country)
        {
            this.Street = street;
            this.Number = number;
            this.Neighborhood = neighborhood;
            this.ZipCode = zipCode;
            this.Complement = complement;
            this.City = city;
            this.State = state;
            this.Country = country;
        }
        public void showInfo()
        {
            Console.WriteLine($"Endereço: {Street}, {Number}");
            Console.WriteLine($"Bairro: {Neighborhood}");
            Console.WriteLine($"CEP: {ZipCode}");
            if (Complement != null)
            {
                Console.WriteLine($"Complemento: {Complement}");
            }
            Console.WriteLine($"Cidade: {City}");
            Console.WriteLine($"Estado: {State}");
            Console.WriteLine($"País: {Country}");
        }

        public override string ToString()
        {
            return $"Endereco: {Street}, {Number}" +
                $"Bairro {Neighborhood}" +
                $"CEP: {ZipCode}" +
                $"Complemento {Complement}" +
                $"Cidade {City}" +
                $"Estado {State}" +
                $"Pais {Country}"
            ;
        }
    }
}