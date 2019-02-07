using Assignment1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Console.WriteLine(TextProvider.WELCOME_TEXT);

            // TODO Implement functionality

            Console.ReadLine();
        }
    }


    static class TextProvider
    {
        public static string WELCOME_TEXT = "\n  /$$$$$$$$ /$$                        /$$$$$$                            /$$$$$$$                      /$$\n"
                                            + " |__  $$__/| $$                       /$$__  $$                          | $$__  $$                    | $$\n"
                                            + "    | $$   | $$$$$$$   /$$$$$$       | $$  \\__/  /$$$$$$   /$$$$$$       | $$  \\ $$  /$$$$$$   /$$$$$$ | $$  /$$$$$$   /$$$$$$\n"
                                            + "    | $$   | $$__  $$ /$$__  $$      | $$       |____  $$ /$$__  $$      | $$  | $$ /$$__  $$ |____  $$| $$ /$$__  $$ /$$__  $$\n"
                                            + "    | $$   | $$  \\ $$| $$$$$$$$      | $$        /$$$$$$$| $$  \\__/      | $$  | $$| $$$$$$$$  /$$$$$$$| $$| $$$$$$$$| $$  \\__/\n"
                                            + "    | $$   | $$  | $$| $$_____/      | $$    $$ /$$__  $$| $$            | $$  | $$| $$_____/ /$$__  $$| $$| $$_____/| $$\n"
                                            + "    | $$   | $$  | $$|  $$$$$$$      |  $$$$$$/|  $$$$$$$| $$            | $$$$$$$/|  $$$$$$$|  $$$$$$$| $$|  $$$$$$$| $$\n"
                                            + "    |__/   |__/  |__/ \\_______/       \\______/  \\_______/|__/            |_______/  \\_______/ \\_______/|__/ \\_______/|__/\n";

    }

    namespace Models
    {
        public enum VehicleType { TRUCK, CAR, MOTORCYCLE, };
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
        
        abstract class Vehicle 
        {
            private static int nextVehicleId;
      
            public Vehicle(string licensePlate, int price, int yearBuilt, VehicleType type)
            {
                if (licensePlate == null || licensePlate.Length < 4 || licensePlate.Length > 10)
                    throw new ArgumentException("A licencse plate must be provided and in the range 4-10");
                
                LicensePlate = licensePlate;
                Price = price;
                Type = type;
                YearBuilt = yearBuilt;
                PriceStrategy = new NormalPriceStrategy();
                VehicleId = Interlocked.Increment(ref nextVehicleId);
            }

            public string LicensePlate { get; set; }
            public int Price { get; set; }
            public VehicleType Type { get; private set; }
            public int VehicleId { get; private set; }
            public int YearBuilt { get; }
            public int Age { get => DateTime.Today.Year - YearBuilt; }
            public IPriceStrategy PriceStrategy { get; set; }

            public override string ToString()
            {
                return string.Format("ID: {0}, Type: {1}, License: {2}, Price: {3}", VehicleId, Type, LicensePlate, Price);
            }

        }

        class Car : Vehicle
        {

            public Car(CarBrandModel model, string licensePlate, int price, int yearBuilt, VehicleType type) 
                : base(licensePlate, price, yearBuilt, type)
            {
                CarModel = model;
            }

            public CarBrandModel CarModel { get; }
            public FuelType FuelType { get; set; }
            public int HorsePower { get; set; }
            public int NrOfSeats { get; set; }
        }

        class Truck : Vehicle
        {
            public Truck(TruckBrandModel model, int maxWeight, string licensePlate, int price, int yearBuilt, VehicleType type) 
                : base(licensePlate, price, yearBuilt, type)
            {
                TruckModel = model;
                MaxWeight = maxWeight;
            }

            public TruckBrandModel TruckModel { get; }
            public int MaxWeight { get; set; }
        }

        /// <summary>
        /// Strategy Pattern for defining the price of a vehicle
        /// </summary>
        interface IPriceStrategy { int Price(int rawPrice); }

        /// <summary>
        /// Default Strategy should be used to get the base price.
        /// </summary>
        /// <returns>
        /// The base price
        /// </returns>
        class NormalPriceStrategy : IPriceStrategy {
            public int Price(int rawPrice) { return rawPrice; }
        }

        /// <summary>
        /// Sale Strategy should be used to get the base price at a discount.
        /// </summary>
        /// <returns>
        /// The Base Price - given Percentage 
        /// </returns>
        /// <example>
        /// Instantiation of the sale strategy would be:
        /// <code>IPriceStrategy sale30 = new SalePriceStrategy(30);</code>
        /// Then after invoking the <code>Price(100000)</code> method, we would
        /// get the base price of 100000 minus the 30%. BASE - (30% of BASE).
        /// Returns: 70000
        /// </example>
        class SalePriceStrategy : IPriceStrategy
        {
            public int SalePercentage { get; }

            public SalePriceStrategy(int salePercentage) { SalePercentage = salePercentage; }

            public int Price(int rawPrice) { return rawPrice - (int)((double) SalePercentage / 100 * rawPrice); }
        }

        /// <summary>
        /// Inflation Strategy should be used to get the base price at an increased price.
        /// </summary>
        /// <returns>
        /// The Base Price + given Percentage 
        /// </returns>
        /// <example>
        /// Instantiation of the sale strategy would be:
        /// <code>IPriceStrategy sale30 = new InflationPriceStrategy(30);</code>
        /// Then after invoking the <code>Price(100000)</code> method, we would
        /// get the base price of 100000 plus the 30%. BASE + (30% of BASE).
        /// Returns: 130000
        /// </example>
        class InflationPriceStrategy : IPriceStrategy
        {
            public int InflationPercentage { get; }

            public InflationPriceStrategy(int salePercentage) { InflationPercentage = salePercentage; }

            public int Price(int rawPrice) { return rawPrice + (int)((double)InflationPercentage / 100 * rawPrice); }
        }
    }

    namespace DBAccess
    {
        interface IREST<T>
        {
            T GET(int id);
            T POST(T t);
            void PUT(int id);
            void DELETE(int id);
        }

        class InMemoryDB
        {
            public InMemoryDB()
            {
                Vehicles = new List<Vehicle>();
            }

            public List<Vehicle> Vehicles { get; private set; }

            public IOrderedEnumerable<Vehicle> VehiclesOfAge(int age)
            {
                return from vehicle in Vehicles
                where vehicle.Age == age
                orderby vehicle.VehicleId
                select vehicle;
            }

            public void AddVehicle(Vehicle vehicle)
            {
                Vehicles.Add(vehicle);
            }

            public void RemoveVehicle(Vehicle vehicle)
            {
                Vehicles.Remove(vehicle);
            }
            // todo
        }


    }
}