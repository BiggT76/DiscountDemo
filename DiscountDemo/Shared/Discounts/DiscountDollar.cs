using Coin.Shared.Discounts;
using Coin.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coin.Shared
{
    public class DiscountDollar : DiscountBase, IDiscount
    {
        public void Apply(ODataOrderHeader order, DdfDiscount discount)
        {
            order.DiscountId = discount.DiscountId;
            order.DiscountAmount = discount.DiscountAmount;
            order.OrderTotal = Calculate(order.DealerNetListTotal, discount.DiscountAmount);

            if (order.OrderTotal < 0)
                ThrowNegativeTotalException(order.OrderId.ToString());
        }

        public void Apply(OrderHeader order, DdfDiscount discount)
        {
            order.DiscountId = discount.DiscountId;
            order.OrderPricing.DiscountAmount = discount.DiscountAmount;
            order.OrderPricing.DealerTotal = Calculate(order.OrderPricing.DealerNetListTotal.Value, discount.DiscountAmount);

            if (order.OrderPricing.DealerTotal < 0)
                ThrowNegativeTotalException(order.OrderId.ToString());
        }
    }
}
