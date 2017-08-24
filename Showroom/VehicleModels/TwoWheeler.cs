using Showroom.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom.VehicleModels
{
    public class TwoWheeler : IVehicle
    {
        public int Id { get; }

        public string Company { get; }

        public string Name { get; }

        public decimal LeasePricePerDay { get; }

        public decimal SellPrice { get; }

        public int CompareTo(IVehicle other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
