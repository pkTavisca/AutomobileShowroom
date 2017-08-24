using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom
{
    public class Register
    {
        public List<Invoice> SoldList { get; }
        public List<Invoice> RentedList { get; }
        public List<Invoice> MaintainenceList { get; }

        public Register()
        {
            SoldList = new List<Invoice>();
            RentedList = new List<Invoice>();
            MaintainenceList = new List<Invoice>();
        }

        public decimal GetTotalMaintainenceSaleForToday()
        {
            decimal totalSales = 0;
            foreach (var registerEntry in MaintainenceList)
            {
                if (registerEntry.Date.Date == DateTime.Today)
                    totalSales += registerEntry.Price;
            }
            return totalSales;
        }

        public decimal GetTotalRentSaleForToday()
        {
            decimal totalSales = 0;
            foreach (var registerEntry in RentedList)
            {
                if (registerEntry.Date.Date == DateTime.Today)
                    totalSales += registerEntry.Price;
            }
            return totalSales;
        }

        public decimal GetTotalSalesForToday()
        {
            decimal totalSales = 0;
            foreach (var registerEntry in SoldList)
            {
                if (registerEntry.Date.Date == DateTime.Today)
                    totalSales += registerEntry.Price;
            }
            return totalSales;
        }
    }
}
