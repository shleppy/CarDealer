using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.DBAccess
{
    class InMemoryDB : IDBAccess<Vehicle>
    {
        CarDealer Dealer;

        public InMemoryDB()
        {
            Dealer = new CarDealer();
        }

        public void DELETE(int id)
        {
            Dealer.RemoveVehicle(id);
        }

        public Vehicle GET(int id)
        {
            return Dealer.FindVehicleByID(id);
        }

        public Vehicle GET(string license)
        {
            return Dealer.FindVehicleByLicensePlate(license);
        }

        public Vehicle POST(Vehicle vehicle)
        {
            Vehicle v = vehicle;
            Dealer.AddVehicle(v);
            return v;
        }

        public void PUT(int id)
        {
            throw new NotImplementedException();
        }

        // todo
    }
}
