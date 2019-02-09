using Assignment1.Commands;
using Assignment1.DBAccess;
using Assignment1.Utils;
using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class CarDealerApplication
    {
        private static readonly IDBAccess<Vehicle> Database = new InMemoryDB();

        public void Run()
        {
            Console.WriteLine(TextProvider.WELCOME_TEXT);
            // TODO Implement functionality

            Console.WriteLine(TextProvider.MAIN_MENU);
            Console.WriteLine(TextProvider.COMMANDS);

            IMenuCommand command = new AddVehicleCommand();
            command.Execute(Database);

            // wait for input to exit
            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}
