using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Vehicles
{
    class Truck : Vehicle
    {
        public Truck(string brand, string model, int maxWeight, string licensePlate, int price, int yearBuilt, VehicleType type)
            : base(licensePlate, price, yearBuilt, type)
        {
            Brand = brand;
            Model = model;
            MaxWeight = maxWeight;
        }

        public string Brand { get; }
        public string Model { get; }
        public int MaxWeight { get; set; }
    }
}
