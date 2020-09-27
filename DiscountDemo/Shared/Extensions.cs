using System;
using System.Collections.Generic;
using System.Text;

namespace Coin.Shared
{
    public static class Extensions
    {
        public static decimal ConvertToPercentage(this decimal value)
        {
            return value / 100;
        }

        /// <summary>
        /// The default for Math.Round is not what's used in accounting.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ApplyBankersRounding(this decimal value)
        {
            return Math.Round(value, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Returns a DiscountType based on the value of isPercentValue
        /// </summary>
        /// <param name="isPercentValue">The boolean representing if a discount is percentage or dollars.</param>
        /// <returns></returns>
        public static DiscountType ReturnDiscountTypeFromBool(bool isPercentValue)
        {
            if (isPercentValue)
                return DiscountType.Percent;
            else
                return DiscountType.Dollars;
        }
    }
}
