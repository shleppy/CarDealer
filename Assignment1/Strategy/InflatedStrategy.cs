using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Strategy
{
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
    public class InflatedPriceStrategy : IPriceStrategy
    {
        public int InflationPercentage { get; }

        public InflatedPriceStrategy(int salePercentage) { InflationPercentage = salePercentage; }

        public int Price(int rawPrice) { return rawPrice + (int)((double)InflationPercentage / 100 * rawPrice); }
    }
}
