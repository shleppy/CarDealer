using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DBAccess;
using Assignment1.Utils;
using Assignment1.Vehicles;

namespace Assignment1.Commands
{
    class RemoveVehicleCommand : IMenuCommand
    {
        public void Execute(IDBAccess<Vehicle> database)
        {
            int num = InputHelper.GetValidIntegerInput("Enter ID of vehicle to delete: ");
            Vehicle v = database.GET(num);
            InputHelper.GetValidConfirmationInput($"Vehicle: {v.LicensePlate}, [{v.YearBuilt}]\nAre you sure you want to remove vehicle {v.VehicleId}? (y/n): ");
            database.DELETE(num);
        }
    }
}
