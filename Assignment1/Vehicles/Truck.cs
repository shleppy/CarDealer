using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Vehicles
{
    class Truck : Vehicle
    {
        public Truck(TruckBrandModel model, int maxWeight, string licensePlate, int price, int yearBuilt, VehicleType type)
            : base(licensePlate, price, yearBuilt, type)
        {
            TruckModel = model;
            MaxWeight = maxWeight;
        }

        public TruckBrandModel TruckModel { get; }
        public int MaxWeight { get; set; }
    }
}
