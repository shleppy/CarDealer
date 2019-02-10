using Assignment1.Utils;
using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Commands.VehicleCommands
{
    class ChangeNrOfSeatsCommand : IVehicleModCommand<Car>
    {
        public Car Execute(Car v)
        {
            int seats = InputHelper.GetValidIntegerInput("Enter the number of seats: ");
            v.NrOfSeats = seats;
            return v;
        }
    }
}
