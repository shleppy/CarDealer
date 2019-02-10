using Assignment1.Utils;
using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Commands.VehicleCommands
{
    class ChangeHorsePowerCommand : IVehicleModCommand<Car>
    {
        public Car Execute(Car v)
        {
            int hp = InputHelper.GetValidIntegerInput("Enter the amount of horse power: ");
            v.HorsePower = hp;
            return v;
        }
    }
}
