using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Strategy
{
    /// <summary>
    /// Default Strategy should be used to get the base price.
    /// </summary>
    /// <returns>
    /// The base price
    /// </returns>
    public class NormalPriceStrategy : IPriceStrategy
    {
        public int Price(int rawPrice) { return rawPrice; }
    }
}
