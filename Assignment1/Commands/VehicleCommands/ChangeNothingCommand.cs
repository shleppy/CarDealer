using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Commands.VehicleCommands
{
    class ChangeNothingCommand : IVehicleModCommand<Vehicle>
    {
        public Vehicle Execute(Vehicle v)
        {
            Console.WriteLine("Exiting...");
            return v;
        }
    }
}
