using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Commands.VehicleCommands
{
    interface IVehicleModCommand<T> where T : Vehicle
    {
        T Execute(T v);
    }
}
