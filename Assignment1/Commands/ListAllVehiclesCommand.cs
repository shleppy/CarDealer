using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DBAccess;
using Assignment1.Vehicles;

namespace Assignment1.Commands
{
    class ListAllVehiclesCommand : IMenuCommand
    {
        public void Execute(IDBAccess<Vehicle> database)
        {
            // list all vehicles
            Console.WriteLine("\nAll Cars:\n\n");
            PrintCars((IEnumerable<Car>)database.GET().Where(x => x.Type == VehicleType.CAR));


            Console.WriteLine("\nAll Trucks:\n\n");
        }

        private void PrintCars(IEnumerable<Car> cars)
        {
            int idColWidth = cars.Max(x => x.VehicleId);
            int brandColWidth = cars.Max(x => x.Brand.Length);
            int modelColWidth = cars.Max(x => x.Model.Length);
            int licenseColWidth = cars.Max(x => x.LicensePlate.Length);
            int priceColWidth = cars.Max(x => x.Price);
            int yearColWidth = cars.Max(x => x.YearBuilt);

            // Header
            Console.WriteLine($"| {"ID".PadRight(idColWidth)} | " +
                $"{"Licanse".PadRight(licenseColWidth)} | " +
                $"{"Brand".PadRight(brandColWidth)} | " +
                $"{"Model".PadRight(modelColWidth)} | " +
                $"{"Price".PadRight(priceColWidth)} | " +
                $"{"Year".PadRight(yearColWidth)} |");

            // Data
            foreach (var car in cars)
            {
                Console.WriteLine($"| {car.LicensePlate.PadRight(licenseColWidth)} | " +
                    $"{car.Brand.PadRight(brandColWidth)} | " +
                    $"{car.Model.PadRight(modelColWidth)} | " +
                    $"{car.Price.ToString().PadRight(priceColWidth)} | " +
                    $"{car.YearBuilt.ToString().PadRight(yearColWidth)} |");
            }
        }

        private void PrintTrucks(IDBAccess<Vehicle> database)
        {

        }

    }
}
