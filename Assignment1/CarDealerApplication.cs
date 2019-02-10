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
