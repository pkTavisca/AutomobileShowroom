using Showroom;
using Showroom.VehicleModels;
using Xunit;

namespace AutomobileShowroomFixture
{
    public class RegisterFixture
    {
        [Fact]
        public void GetTotalSalesForToday_ShouldReturnTodaysSale_WhenValidInput()
        {
            Register register = new Register();
            register.SoldList.Add(new Invoice(new Car() { SellPrice = 10 }, 10));
            Assert.Equal(10, register.GetTotalSalesForToday());
        }

        [Fact]
        public void GetTotalRentedForToday_ShouldReturnTodaysRentedSale_WhenValidInput()
        {
            Register register = new Register();
            register.RentedList.Add(new Invoice(new Car() { LeasePricePerDay = 10 }, 100));
            Assert.Equal(100, register.GetTotalRentSaleForToday());
        }

        [Fact]
        public void GetTotalRepairedForToday_ShouldReturnTodaysRepairedSale_WhenValidInput()
        {
            Register register = new Register();
            register.MaintainenceList.Add(new Invoice(new Car() { LeasePricePerDay = 10 }, 100));
            Assert.Equal(100, register.GetTotalMaintainenceSaleForToday());
        }
    }
}
