using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DBAccess;
using Assignment1.Strategy;
using Assignment1.Utils;
using Assignment1.Vehicles;

namespace Assignment1.Commands
{
    class IncreasePricesCommand : IMenuCommand
    {
        public void Execute(IDBAccess<Vehicle> database)
        {
            // increase all prices
            int percentage = InputHelper.GetValidIntegerInput("Please enter by how much percent you would like to increase the prices: ");
            UpdatePrices(database, percentage);
        }

        private void UpdatePrices(IDBAccess<Vehicle> database, int percentage)
        {
            foreach (var vehicle in database.GET())
            {
                vehicle.PriceStrategy = new InflatedPriceStrategy(percentage);
                database.PUT(vehicle);
            }
        }

    }
}
