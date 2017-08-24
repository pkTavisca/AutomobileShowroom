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
    }
}
