using Assignment1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.DBAccess
{
    interface IDBAccess<T>
        where T : Vehicle
    {
        IEnumerable<T> GET();
        T GET(int id);
        T POST(T t);
        void PUT(int id);
        void DELETE(int id);
        void PRINT();
    }
    
}
