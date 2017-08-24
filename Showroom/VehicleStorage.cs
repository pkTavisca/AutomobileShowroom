using Showroom.Contracts;
using System;
using System.Collections.Generic;

namespace Showroom
{
    public class VehicleStorage
    {
        Dictionary<IVehicle, int> _vehicles = new Dictionary<IVehicle, int>();

        public void Add(IVehicle vehicle)
        {
            if (_vehicles.ContainsKey(vehicle))
                _vehicles[vehicle]++;
            else
                _vehicles[vehicle] = 1;
        }

        public void Remove(IVehicle vehicle)
        {
            if (_vehicles.ContainsKey(vehicle) == false) return;
            if (_vehicles[vehicle] == 1)
                _vehicles.Remove(vehicle);
            else
                _vehicles[vehicle]--;
        }

        public int Count()
        {
            return _vehicles.Count;
        }
    }
}
