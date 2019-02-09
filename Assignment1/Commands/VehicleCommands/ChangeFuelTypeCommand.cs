using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DBAccess;
using Assignment1.Utils;
using Assignment1.Vehicles;

namespace Assignment1.Commands.VehicleCommands
{
    class ChangeFuelTypeCommand<T> : IVehicleModCommand<Car>
    {
        public Car Execute(Car v)
        {
            string fueltype = InputHelper.GetValidStringInput("Enter Fueltype (default=Gasoline): ");
            switch (fueltype.ToLower())
            {
                case "gasoline": v.FuelType = FuelType.GASOLINE; break;
                case "hybride":  v.FuelType = FuelType.HYBRIDE; break;
                case "electric": v.FuelType = FuelType.ELECTRIC; break;
                case "diesel": v.FuelType = FuelType.DIESEL; break;
                default:
                    Console.WriteLine($"Couldn't find {fueltype}, defaulting to gasoline.");
                    v.FuelType = FuelType.GASOLINE;
                    break;
            }
            return v;
        }
    }
}
