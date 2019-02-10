using Assignment1.Strategy;
using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class CarDealer
    {
        List<Vehicle> Vehicles = new List<Vehicle>();

        // LINQ methods

        /// <summary>
        /// Add vehicle to list
        /// </summary>
        /// <param name="v"></param>
        public void AddVehicle(Vehicle v) => Vehicles.Add(v);

        /// <summary>
        /// Remove vehicle from list
        /// </summary>
        /// <param name="vehicleId"></param>
        public void RemoveVehicle(int vehicleId)
        {
            Vehicles.Remove(Vehicles.Find(x => x.VehicleId == vehicleId));
        }

        /// <summary>
        /// Retrieve all vehicles
        /// </summary>
        /// <returns></returns>
        public List<Vehicle> GetAllVehicles() => this.Vehicles;

        /// <summary>
        /// Returns the vehicle corresponding to the specified ID.
        /// </summary>
        public Vehicle FindVehicleByID(int vehicleId) => Vehicles.Find(x => x.VehicleId == vehicleId);

        /// <summary>
        /// Returns total number of vehicles.
        /// </summary>
        public int TotalVehicles => this.Vehicles.Count;

        /// <summary>
        /// Returns total value of all vehicles
        /// </summary>
        public int TotalVehiclesNetWorth => this.Vehicles.Select(x => x.Price).Sum();

        /// <summary>
        /// Returns price of the specified vehicle if found.
        /// </summary>
        public int? PriceOfVehicle(int vehicleId)
        {
            Vehicle v = this.Vehicles.Find(x => x.VehicleId == vehicleId);
            return v?.Price;
        }

        /// <summary>
        /// Increases price of all vehicles by specified percentage (e.g. 30% -> sets to 130%).
        /// </summary>
        /// <param name="percentage">Percentage of modification in whole percentages</param>
        public void IncreaseAllPricesByPercentage(int percentage)
        {
            Vehicles.ForEach(v => v.PriceStrategy = new InflatedPriceStrategy(percentage));
        }

        /// <summary>
        /// Decreases price of all vehicles by specified percentage (e.g. 30% -> sets to 70%).
        /// </summary>
        /// <param name="percentage"></param>
        public void DecreaseAllPricesByPercentage(int percentage)
        {
            Vehicles.ForEach(v => v.PriceStrategy = new SalePriceStrategy(percentage));
        }

        /// <summary>
        /// Returns the found vehicle with the specified license plate.
        /// </summary>
        /// <param name="license"></param>
        /// <returns></returns>
        public Vehicle FindVehicleByLicensePlate(string license) => Vehicles.Find(x => x.LicensePlate.Equals(license));

        /// <summary>
        /// Returns an IEnumerable of all vehicles within the boundarys of the price range (low >= N <= high).
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public IEnumerable<Vehicle> FindVehiclesInPriceRangeOf(int low, int high)
        {
            return this.Vehicles.Where(x => x.Price >= low && x.Price <= high);
        }
        
    }
}
