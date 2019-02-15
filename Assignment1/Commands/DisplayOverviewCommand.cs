using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DBAccess;
using Assignment1.Vehicles;

namespace Assignment1.Commands
{
    class DisplayOverviewCommand : IMenuCommand
    {
        public void Execute(IDBAccess<Vehicle> database)
        {
            //display impportant info
            Console.WriteLine("Company Overview:");

            IEnumerable<Vehicle> cars = database.GET();
            PrintVehicleCount(cars);
            PrintCarCount(cars);
            PrintTruckCount(cars);
            PrintTotalValue(cars);
        }

        private void PrintVehicleCount(IEnumerable<Vehicle> cars)
        {
            int totalVehicles = cars.Count();
            string totVehFormat = String.Format(">Vehicle Amount: {0,15}", totalVehicles);
            Console.WriteLine(totVehFormat);
        }

        private void PrintCarCount(IEnumerable<Vehicle> cars)
        {
            int totalCars = cars.Count(x => x.Type == VehicleType.CAR);
            string totCarFormat = String.Format(">Car Amount:     {0,15}", totalCars);
            Console.WriteLine(totCarFormat);
        }

        private void PrintTruckCount(IEnumerable<Vehicle> cars)
        {
            int totalTrucks = cars.Count(x => x.Type == VehicleType.TRUCK);
            string totTruckFormat = String.Format(">Truck Amount:   {0,15}", totalTrucks);
            Console.WriteLine(totTruckFormat);
        }

        private void PrintTotalValue(IEnumerable<Vehicle> cars)
        {
            int totalValue = cars.Sum(x => x.Price);
            string totValFormat = String.Format(">Total Value:    {0,15}", totalValue);
            Console.WriteLine(totValFormat);
        }

    }
}
