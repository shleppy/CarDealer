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
            Console.WriteLine(TextProvider.MAIN_MENU);
            Database.POST(new Car("bmw", "m5", "test-2", 57500, 2015, VehicleType.CAR));
            Database.POST(new Car("audi", "rs6", "ok-522", 125000, 2017, VehicleType.CAR));
            Database.POST(new Car("volkswagen", "golfR", "oh-42-ho", 43000, 2018, VehicleType.CAR));
            Database.POST(new Truck("volkswagen", "golfR", 1500, "oh-42-ho", 43000, 2018, VehicleType.TRUCK));
            while (true) {
                
                Console.Write("\n>>> ");
                string command = Console.ReadLine();

                getCommand(command).Execute(Database);
            }
        }

        public IMenuCommand getCommand(string command)
        {
             return CommandFactory.GetMenuCommand(command);
        }
    }
}
