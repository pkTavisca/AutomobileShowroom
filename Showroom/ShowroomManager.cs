using Showroom.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom
{
    public class ShowroomManager
    {
        private VehicleStorage _storage;
        private Register _register;

        public ShowroomManager(VehicleStorage storage, Register register)
        {
            _storage = storage ?? new VehicleStorage();
            _register = register ?? new Register();
        }

        public void Sell(IVehicle vehicle, decimal price)
        {
            _storage.Remove(vehicle);
            _register.SoldList.Add(new RegisterEntry(vehicle, price));
        }

        public void Rent(IVehicle vehicle, int noOfDays)
        {
            _storage.Remove(vehicle);
            _register.RentedList.Add(new RegisterEntry(vehicle, noOfDays * vehicle.LeasePricePerDay));
        }

        public void SendForMaintainence(IVehicle vehicle, decimal repairCost)
        {
            _storage.Add(vehicle);
            _register.MaintainenceList.Add(new RegisterEntry(vehicle, repairCost));
        }

        public string TestDrive(IVehicle vehicle)
        {
            return $"{vehicle.Name} was test driven.";
        }
    }
}
