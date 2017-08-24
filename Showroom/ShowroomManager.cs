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

        public void Sell(IVehicle vehicle)
        {
            _storage.Remove(vehicle);
            _register.SoldList.Add(new RegisterEntry(vehicle));
        }

        public void Rent(IVehicle vehicle, int noOfDays)
        {

        }

        public void SendForMaintainence(IVehicle vehicle)
        {

        }

        public bool TestDrive(IVehicle vehicle)
        {
            return true;
        }
    }
}
