using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Utils.Strategy
{
    /// <summary>
    /// Strategy Pattern for defining the price of a vehicle
    /// </summary>
    public interface IPriceStrategy { int Price(int rawPrice); }

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
    public class SalePriceStrategy : IPriceStrategy
    {
        public int SalePercentage { get; }

        public SalePriceStrategy(int salePercentage) { SalePercentage = salePercentage; }

        public int Price(int rawPrice) { return rawPrice - (int)((double)SalePercentage / 100 * rawPrice); }
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
    public class InflatedPriceStrategy : IPriceStrategy
    {
        public int InflationPercentage { get; }

        public InflatedPriceStrategy(int salePercentage) { InflationPercentage = salePercentage; }

        public int Price(int rawPrice) { return rawPrice + (int)((double)InflationPercentage / 100 * rawPrice); }
    }
}
