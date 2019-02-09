using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Vehicles
{
    public class Car : Vehicle
    {

        public Car(CarBrandModel model, string licensePlate, int price, int yearBuilt, VehicleType type)
            : base(licensePlate, price, yearBuilt, type)
        {
            CarModel = model;
        }

        public CarBrandModel CarModel { get; }
        public FuelType FuelType { get; set; }
        public int HorsePower { get; set; }
        public int NrOfSeats { get; set; }
        public string Color { get; set; }
    }
}
