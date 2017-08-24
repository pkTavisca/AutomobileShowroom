using Showroom.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom.VehicleModels
{
    public class TwoWheeler : IVehicle
    {
        public int Id { get; set; }

        public string Company { get; set; }

        public string Name { get; set; }

        public decimal LeasePricePerDay { get; set; }

        public decimal SellPrice { get; set; }

        public int CompareTo(IVehicle other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
