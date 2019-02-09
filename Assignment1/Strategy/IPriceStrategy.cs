using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Strategy
{
    /// <summary>
    /// Strategy Pattern for defining the price of a vehicle
    /// </summary>
    public interface IPriceStrategy { int Price(int rawPrice); }
}
