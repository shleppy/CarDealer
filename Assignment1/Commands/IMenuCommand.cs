using Assignment1.DBAccess;
using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Commands
{
    interface IMenuCommand
    {
        void Execute(IDBAccess<Vehicle> database);
    }
}
