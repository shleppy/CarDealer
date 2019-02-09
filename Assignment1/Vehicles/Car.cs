using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Vehicles
{
    public class Car : Vehicle
    {

        public Car(string brand, string model, string licensePlate, int price, int yearBuilt, VehicleType type)
            : base(licensePlate, price, yearBuilt, type)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public FuelType FuelType { get; set; }
        public int HorsePower { get; set; }
        public int NrOfSeats { get; set; }
        public string Color { get; set; }
    }
}
