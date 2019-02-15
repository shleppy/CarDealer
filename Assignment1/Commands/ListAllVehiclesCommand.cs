using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DBAccess;
using Assignment1.Vehicles;

namespace Assignment1.Commands
{
    public class ListAllVehiclesCommand : IMenuCommand
    {
        public void Execute(IDBAccess<Vehicle> database)
        {
            database = (InMemoryDB)database;
            // list all vehicles
            Console.WriteLine("\nAll Cars:\n");
            PrintCars(database.GET().Where(x => x.Type == VehicleType.CAR).Cast<Car>());
            PrintTrucks(database.GET().Where(x => x.Type == VehicleType.TRUCK).Cast<Truck>());

            Console.WriteLine("\nAll Trucks:\n\n");
        }

        public void PrintCars(IEnumerable<Car> cars)
        {
            int idColWidth = cars.Max(x => x.VehicleId.ToString().Length) + 2;
            int brandColWidth = cars.Max(x => x.Brand.Length) + 5;
            int modelColWidth = cars.Max(x => x.Model.Length) + 5;
            int licenseColWidth = cars.Max(x => x.LicensePlate.Length);
            int priceColWidth = cars.Max(x => x.Price.ToString().Length) + 5;
            int yearColWidth = cars.Max(x => x.YearBuilt.ToString().Length);

            if (licenseColWidth < 13) licenseColWidth = 13;
            if (brandColWidth < 5) brandColWidth = 5;
            if (modelColWidth < 5) modelColWidth = 5;
            if (priceColWidth < 5) priceColWidth = 5;
            if (yearColWidth < 4) yearColWidth = 4;

            // Header
            Console.WriteLine($"| {"ID".PadRight(idColWidth)} | " +
                $"{"License".PadRight(licenseColWidth)} | " +
                $"{"Brand".PadRight(brandColWidth)} | " +
                $"{"Model".PadRight(modelColWidth)} | " +
                $"{"Price".PadRight(priceColWidth)} | " +
                $"{"Year".PadRight(yearColWidth)} |");
            Console.WriteLine($"|-{"-".PadRight(idColWidth, '-')}-" +
                $"|-{"-".PadRight(licenseColWidth, '-')}-" +
                $"|-{"-".PadRight(brandColWidth, '-')}-" +
                $"|-{"-".PadRight(modelColWidth, '-')}-" +
                $"|-{"-".PadRight(priceColWidth, '-')}-" +
                $"|-{"-".PadRight(yearColWidth, '-')}-|");

            // Data
            foreach (var car in cars)
            {
                Console.WriteLine($"| {car.VehicleId.ToString().PadRight(idColWidth)} | " +
                    $"{car.LicensePlate.PadRight(licenseColWidth)} | " +
                    $"{car.Brand.PadRight(brandColWidth)} | " +
                    $"{car.Model.PadRight(modelColWidth)} | " +
                    $"{car.Price.ToString().PadRight(priceColWidth)} | " +
                    $"{car.YearBuilt.ToString().PadRight(yearColWidth)} |");
            }
        }

        private void PrintTrucks(IEnumerable<Truck> trucks)
        {
            // TODO print all trucks like cars
        }

    }
}
