using Assignment1.Commands.VehicleCommands;
using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Commands
{
    class CommandFactory
    {
        public static IVehicleModCommand<Vehicle> GetCarInfoCommand(int command)
        {
            switch (command)
            {
                case 1: return (IVehicleModCommand<Vehicle>)new ChangeFuelTypeCommand();
                case 2: return (IVehicleModCommand<Vehicle>)new ChangeHorsePowerCommand();
                case 3: return (IVehicleModCommand<Vehicle>)new ChangeNrOfSeatsCommand(); 
                case 4: return (IVehicleModCommand<Vehicle>)new ChangeColorCommand();
                default: return new ChangeNothingCommand(); ;
            }
        }
    }
}
