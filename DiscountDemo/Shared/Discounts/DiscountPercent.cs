using Coin.Shared.Discounts;
using Coin.Shared.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Coin.Shared
{
    public class DiscountPercent : DiscountBase, IDiscount
    {
        public void Apply(ODataOrderHeader order, DdfDiscount discount)
        {
            order.DiscountId = discount.DiscountId;
            order.DiscountAmount = discount.DiscountAmount;
            order.DiscountDollarAmount = 
                (discount.DiscountAmount.ConvertToPercentage() * order.DealerNetListTotal).ApplyBankersRounding();
            order.OrderTotal = Calculate(order.DealerNetListTotal, order.DiscountDollarAmount);
            
            if (order.OrderTotal < 0)
                ThrowNegativeTotalException(order.OrderId.ToString());
        }

        public void Apply(OrderHeader order, DdfDiscount discount)
        {
            order.DiscountId = discount.DiscountId;
            order.OrderPricing.DiscountAmount = discount.DiscountAmount;
            decimal orderTotal = order.OrderPricing.DealerNetListTotal.Value;
            decimal discountDollarAmount = 
                (discount.DiscountAmount.ConvertToPercentage() * orderTotal).ApplyBankersRounding();
            order.OrderPricing.DiscountDollarAmount = discountDollarAmount;
            order.OrderPricing.DealerTotal = Calculate(orderTotal, discountDollarAmount);

            if (order.OrderPricing.DealerTotal < 0)
                ThrowNegativeTotalException(order.OrderId.ToString());
        }
    }
}
