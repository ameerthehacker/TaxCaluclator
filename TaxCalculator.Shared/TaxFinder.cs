using System;

namespace TaxCalculator.Shared
{
    public class TaxFinder
    {
        public static double CalculateTax(int amount) {
            return amount * 0.3;
        }
    }
}
