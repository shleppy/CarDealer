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
        public static IVehicleModCommand<Car> GetCarInfoCommand(int command)
        {       
            switch (command)
            {
                case 1: return new ChangeFuelTypeCommand();
                case 2: return new ChangeHorsePowerCommand();
                case 3: return new ChangeNrOfSeatsCommand(); 
                case 4: return new ChangeColorCommand();
                default: return new ChangeNothingCommand<Car>(); ;
            }
        }
    }
}
