using Showroom.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom
{
    public class RegisterEntry
    {
        public DateTime Date { get; }
        public IVehicle Vehicle { get; }
        public decimal Price { get; }

        public RegisterEntry(IVehicle vehicle, decimal Price)
        {
            Vehicle = vehicle;
            Date = DateTime.Now;
            this.Price = Price;
        }
    }
}
