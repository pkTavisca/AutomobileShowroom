using Showroom;
using Showroom.VehicleModels;
using Xunit;

namespace AutomobileShowroomFixture
{
    public class VehicleStorageFixture
    {
        [Fact]
        public void Adding_a_vehicle()
        {
            VehicleStorage storage = new VehicleStorage();
            Car car = new Car() { Id = 1 };
            storage.Add(car);
            Assert.Equal(1, storage.Count());
        }

        [Fact]
        public void Removing_a_vehicle()
        {
            VehicleStorage storage = new VehicleStorage();
            Car car = new Car() { Id = 1 };
            storage.Add(car);
            storage.Remove(car);
            Assert.Equal(0, storage.Count());
        }
    }
}
