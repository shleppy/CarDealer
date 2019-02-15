using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DBAccess;
using Assignment1.Utils;
using Assignment1.Vehicles;
using Assignment1.Commands;

namespace Assignment1.Commands.SearchCommands
{
    class SearchVehicleByIdCommand : ISearchCommand
    {
        public void Execute(IDBAccess<Vehicle> database)
        {

            //PrintCars(database.GET().First(x => x.VehicleId == id));
        }
    }
}
