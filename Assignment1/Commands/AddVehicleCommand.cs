using Assignment1.Commands.VehicleCommands;
using Assignment1.DBAccess;
using Assignment1.Utils;
using Assignment1.Vehicles;
using System;

namespace Assignment1.Commands
{
    class AddVehicleCommand : IMenuCommand
    {
        readonly string command = "--> Enter Vehicle Type (car or truck, default=Car): ";

        public void Execute(IDBAccess<Vehicle> database)
        {
            Console.Write(command);
            string input = Console.ReadLine();
            if (input.Equals("C")) return;
            if (input.Equals("Q")) System.Environment.Exit(0);

            VehicleType type = input == "truck" ? VehicleType.TRUCK : VehicleType.CAR;

            Vehicle v = (type == VehicleType.CAR) ? (Vehicle)GetCarInfo() : (Vehicle)GetTruckInfo();
            v = GetAdditionalInfo(v);

            FinalizeCommand(database, v);
        }

        private Car GetCarInfo()
        {
            string[] brandModel = InputHelper.GetValidSpaceSeparatedSequenceInput("\n\tEnter Brand and model (brand model): ");
            string license = InputHelper.GetValidStringInput("\tEnter license plate: ");
            int price = InputHelper.GetValidIntegerInput("\tEnter price: ");
            int yearBuilt = InputHelper.GetValidIntegerInput("\tEnter the year the car was built: ");
            return new Car(brandModel[0], brandModel[1], license, price, yearBuilt, VehicleType.CAR);
        }

        private Truck GetTruckInfo()
        {
            string[] brandModel = InputHelper.GetValidSpaceSeparatedSequenceInput("\n\tEnter Brand and model (brand model): ");
            int maxweight = InputHelper.GetValidIntegerInput("\tEnter the maximum weight: ");
            string license = InputHelper.GetValidStringInput("\tEnter license plate: ");
            int price = InputHelper.GetValidIntegerInput("\tEnter price: ");
            int yearBuilt = InputHelper.GetValidIntegerInput("\tEnter the year the truck was built: ");
            return new Truck(brandModel[0], brandModel[1], maxweight, license, price, yearBuilt, VehicleType.TRUCK);
        }

        private Vehicle GetAdditionalInfo(Vehicle v)
        {
            bool answerIsYes = InputHelper.GetValidConfirmationInput("\nWould you like to enter additional info? (y/n): ");
            while (answerIsYes)
            {
                PrintAddtionalCarCommands();
                int command = InputHelper.GetValidIntegerInput("\tEnter a command: ");   
                v = CommandFactory.GetCarInfoCommand(command).Execute(v);
                answerIsYes = InputHelper.GetValidConfirmationInput("\nWould you like to add more? (y/n): ");
            }
            return v;
        } 

        private void PrintAddtionalCarCommands()
        {
            Console.WriteLine("\nAvailable commands: ");
            string commands = "\t1) Change FuelType\n" +
                "\t2) Change HorsePower\n" +
                "\t3) Change NrOfSeats\n" +
                "\t4) Change Color\n" +
                "\tq) Exit\n";
            Console.WriteLine(commands);
        }

        private void FinalizeCommand(IDBAccess<Vehicle> database, Vehicle v)
        {
            PrintSummary(v);
            if (InputHelper.GetValidConfirmationInput("\nAre you sure you want to add this vehicle to the database? (y/n): "))
            {
                database.POST(v);
            }
            else
            {
                Console.WriteLine("Command aborted.");
            }
        }

        private void PrintSummary(Vehicle v)
        {
            //TODO
            Console.WriteLine($"Vehicle {v.VehicleId}:\n" +
                $"\tLicense: {v.LicensePlate}\n" +
                $"\tYear Built: {v.YearBuilt}\n" +
                $"\tPrice: {v.Price}\n");
        }
    }
}
