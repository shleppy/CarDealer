using Assignment1.Commands.SearchCommands;
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

        public static IMenuCommand GetMenuCommand(string command)
        {
            switch (command)
            {
                case "1": return new ListAllVehiclesCommand();
                case "2": return new SearchSubCommand();
                case "3": return new AddVehicleCommand();
                case "4": return new RemoveVehicleCommand();
                case "5": return new IncreasePricesCommand();
                case "6": return new DecreasePricesCommand();
                case "7": return new DisplayOverviewCommand();
                case "h": return new HelpCommand();
                case "q": return new QuitCommand();
                default: return new QuitCommand();
            }
        }

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

        public static ISearchCommand GetSearchCommand(int command)
        {
            switch (command)
            {
                case 1: return new SearchVehicleByIdCommand();
            }
            return null;
        }
    }
}
