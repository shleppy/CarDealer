using Assignment1.Utils.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1.Vehicles
{
    public enum VehicleType { TRUCK, CAR, MOTORCYCLE }

    public enum FuelType { GASOLINE, DIESEL, ELETRIC, HYBRIDE }

    public enum CarBrandModel
    {
        BMW_M3, BMW_M4, BMW_M5, BMW_M6, BMW_MX6,
        AUDI_RS3, AUDI_RS4, AUDI_RS6, AUDI_RS7, AUDI_SQ8,
        VOLKSWAGEN_GOLFR, VOLKSWAGEN_ARTEONR, VOLKSWAGEN_GOLFGTI
    }

    public enum TruckBrandModel
    {
        MERCEDES_ACTROS, MERCEDES_AROCOS, MERCEDES_eARCTROS,
    }

    public abstract class Vehicle
    {
        private static int nextVehicleId;

        private readonly int basePrice;

        public int VehicleId { get; private set; }
        public string LicensePlate { get; set; }
        public VehicleType Type { get; private set; }
        public int YearBuilt { get; }
        public int Age { get => DateTime.Today.Year - YearBuilt; }
        public IPriceStrategy PriceStrategy { get; set; }
        public int Price { get => PriceStrategy.Price(basePrice); }

        public Vehicle(string licensePlate, int price, int yearBuilt, VehicleType type)
        {
            if (licensePlate == null || licensePlate.Length < 4 || licensePlate.Length > 10)
                throw new ArgumentException("A licencse plate must be provided and in the range 4-10");
            if (yearBuilt < 2015)
                throw new ArgumentOutOfRangeException("We only sell recent models of cars.");
            if (price < 30000)
                throw new ArgumentException("The vehicle seems too cheap to sell.");

            basePrice = price;
            LicensePlate = licensePlate;
            Type = type;
            YearBuilt = yearBuilt;
            PriceStrategy = new NormalPriceStrategy();
            VehicleId = Interlocked.Increment(ref nextVehicleId);
        }

        public override string ToString()
        {
            return string.Format("ID: {0}, Type: {1}, License: {2}, Price: {3}", VehicleId, Type, LicensePlate, Price);
        }
    }
}
