using Assignment1.Utils;
using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Commands.VehicleCommands
{
    class ChangeColorCommand : IVehicleModCommand<Car>
    {
        public Car Execute(Car v)
        {
            string color = InputHelper.GetValidStringInput("Enter a color: ");
            v.Color = color;
            return v;
        }
    }
}
