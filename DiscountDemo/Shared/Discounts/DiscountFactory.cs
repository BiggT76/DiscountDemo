using System;
using System.Collections.Generic;
using System.Text;

namespace Coin.Shared.Discounts
{
    public class DiscountFactory
    {
        public static IDiscount Create(DiscountType type)
        {
            if (type == DiscountType.Dollars)
                return new DiscountDollar();
            else if (type == DiscountType.Percent)
                return new DiscountPercent();
            else
                throw new Exception("Discount type not recognized!");
        }
    }
}
