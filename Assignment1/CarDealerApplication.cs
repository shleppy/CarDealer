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
        private static readonly IREST<Vehicle> Database = new InMemoryDB();

        public void Run()
        {
            Console.WriteLine(TextProvider.WELCOME_TEXT);
            // TODO Implement functionality

            do
            {

            } while (true);

            Console.ReadLine();
        }
    }
}
