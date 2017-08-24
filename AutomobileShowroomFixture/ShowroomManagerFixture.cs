using Showroom;
using Showroom.VehicleModels;
using Xunit;

namespace AutomobileShowroomFixture
{
    public class ShowroomManagerFixture
    {
        [Fact]
        public void SellCar_ShouldRemoveCarFromStorage_WhenValidInput()
        {
            VehicleStorage storage = new VehicleStorage();
            Car car = new Car() { Id = 1 };
            storage.Add(car);
            Register register = new Register();
            ShowroomManager manager = new ShowroomManager(storage, register);

            manager.Sell(car);

            Assert.Equal(0, storage.Count());
        }

        [Fact]
        public void Renting_a_car()
        {
            VehicleStorage storage = new VehicleStorage();
            Car car = new Car() { Id = 1 };
            storage.Add(car);
            Register register = new Register();
            ShowroomManager manager = new ShowroomManager(storage, register);

            manager.Sell(car);

            Assert.Equal(0, storage.Count());
        }

        [Fact]
        public void Repairing_a_car()
        {
            VehicleStorage storage = new VehicleStorage();
            Car car = new Car() { Id = 1 };
            Register register = new Register();
            ShowroomManager manager = new ShowroomManager(storage, register);

            manager.SendForMaintainence(car, 100);

            Assert.Equal(1, storage.Count());
        }

        [Fact]
        public void Test_driving_a_car()
        {
            VehicleStorage storage = new VehicleStorage();
            Car car = new Car() { Id = 1, Name = "Maruti" };
            Register register = new Register();
            ShowroomManager manager = new ShowroomManager(storage, register);

            manager.SendForMaintainence(car, 100);

            Assert.Equal("Maruti was test driven.", manager.TestDrive(car));
        }

        [Fact]
        public void Testing_earnings_for_car()
        {
            VehicleStorage storage = new VehicleStorage();
            Car car1 = new Car() { Id = 1, Name = "Maruti", SellPrice = 100 };
            Car car2 = new Car() { Id = 2, Name = "Maruti", LeasePricePerDay = 10 };
            Car car3 = new Car() { Id = 3, Name = "Maruti" };
            Register register = new Register();
            ShowroomManager manager = new ShowroomManager(storage, register);

        }
    }
}
