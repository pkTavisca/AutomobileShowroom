using Showroom.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom
{
    public class Invoice
    {
        public DateTime Date { get; }
        public IVehicle Vehicle { get; }
        public decimal Price { get; }

        public Invoice(IVehicle vehicle, decimal Price)
        {
            Vehicle = vehicle;
            Date = DateTime.Now;
            this.Price = Price;
        }
    }
}
