using Showroom.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom.VehicleModels
{
    public class Car : IVehicle
    {
        public int Id { get; }

        public string Company { get; }

        public string Name { get; }

        public int LeasePricePerDay { get; }

        public int SellPrice { get; }

        public int CompareTo(IVehicle other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
