using oop_fundamentals.Interfaces;
using System;

namespace oop_fundamentals.Models
{
    class AddressAnswer : ITaskAnswer
    {
        Address Address = new Address()
        {
            Index = "31101",
            Country = "Ukraine",
            City = "Kiev",
            Street = "Oportunity",
            House = "1",
            Apartment = "102"
        };


        public void Process()
        {
            Console.WriteLine("Persons new address:");
            Console.WriteLine($"{this.Address.Index} {this.Address.Country}, {this.Address.City} {this.Address.Street}, h.: {this.Address.House}, a.: {this.Address.Apartment}");
        }
    }
}
