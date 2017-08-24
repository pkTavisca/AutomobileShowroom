using Showroom;
using Showroom.VehicleModels;
using Xunit;

namespace AutomobileShowroomFixture
{
    public class ShowroomManagerFixture
    {
        [Fact]
        public void Selling_a_car()
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
    }
}
