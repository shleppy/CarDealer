using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.DBAccess
{
    abstract class InMemoryDB : IREST<Vehicle>
    {
        CarDealer Dealer;

        public InMemoryDB()
        {
            Dealer = new CarDealer();
        }

        public void DELETE(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle GET(int id)
        {
            return Dealer.Find
        }

        public Vehicle POST(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void PUT(int id)
        {
            throw new NotImplementedException();
        }

        // todo
    }
}
