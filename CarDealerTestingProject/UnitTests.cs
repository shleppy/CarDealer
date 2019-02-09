using System;
using Assignment1;
using Assignment1.Vehicles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarDealerTestingProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestVehicleIdIncrements()
        {
            Vehicle car = new Car(CarBrandModel.AUDI_RS6, "V3RY-NICE", 75000, 2016, VehicleType.CAR);
            Vehicle car2 = new Car(CarBrandModel.BMW_M5, "GR3AT", 53000, 2016, VehicleType.CAR);
            Assert.IsTrue(car2.VehicleId == 2, "Car ID of vehicle second car is 2"); 
        }

        [TestMethod]
        public void TestVehiclePriceStrategy()
        {
            Vehicle car = new Car(CarBrandModel.AUDI_RS6, "V3RY-NICE", 100000, 2016, VehicleType.CAR);
            Vehicle car2 = new Car(CarBrandModel.AUDI_SQ8, "GR3AT", 200000, 2016, VehicleType.CAR);
            CarDealer dealer = new CarDealer();
            

            dealer.IncreaseAllPricesByPercentage(30);
            int expected = 130000;
            Console.WriteLine(car.Price);
            Assert.AreEqual(expected, car.Price, 0.0);
        }
    }
}
