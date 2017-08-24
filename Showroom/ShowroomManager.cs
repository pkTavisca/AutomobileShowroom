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
            _register.SoldList.Add(new Invoice(vehicle, vehicle.SellPrice));
        }

        public void Rent(IVehicle vehicle, int noOfDays)
        {
            _storage.Remove(vehicle);
            _register.RentedList.Add(new Invoice(vehicle, noOfDays * vehicle.LeasePricePerDay));
        }

        public void SendForMaintainence(IVehicle vehicle, decimal repairCost)
        {
            _storage.Add(vehicle);
            _register.MaintainenceList.Add(new Invoice(vehicle, repairCost));
        }

        public string TestDrive(IVehicle vehicle)
        {
            return $"{vehicle.Name} was test driven.";
        }

        public decimal GetTotalEarningForToday()
        {
            decimal totalSales = 0;
            totalSales += _register.GetTotalSalesForToday();
            totalSales += _register.GetTotalRentSaleForToday();
            totalSales += _register.GetTotalMaintainenceSaleForToday();
            return totalSales;
        }

        public string TodaysServiceReport()
        {
            string report = string.Empty;
            foreach (var registerEntry in _register.SoldList)
            {
                report += $"Sold id-{registerEntry.Vehicle.Id} for {registerEntry.Price}\n";
            }
            foreach (var registerEntry in _register.RentedList)
            {
                report += $"Rented id-{registerEntry.Vehicle.Id} for {registerEntry.Price}\n";
            }
            foreach (var registerEntry in _register.MaintainenceList)
            {
                report += $"Repaired id-{registerEntry.Vehicle.Id} for {registerEntry.Price}\n";
            }
            return report;
        }
    }
}
