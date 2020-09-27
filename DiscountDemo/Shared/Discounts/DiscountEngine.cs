using Coin.Shared.Discounts;
using Coin.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Coin.Shared
{
    /// <summary>
    /// This class will perform the calculations to convert a discount amount into a dollar amount
    /// as well as update the necessary order totals.
    /// </summary>
    public class DiscountEngine
    {
        IDiscount discount;

        /// <summary>
        /// Create a new instance of the class to perform discount calculation using DiscountType.
        /// </summary>
        /// <param name="type">The enum containing the type of discount to calculate.</param>
        public DiscountEngine(DiscountType type)
        {
            discount = DiscountFactory.Create(type);
        }

        /// <summary>
        /// Calculate the order discount and apply it to the order.
        /// </summary>
        /// <param name="currentOrder">The ODataOrderHeader for the current order.</param>
        /// <param name="discountAmount">The decimal for the discount amount.</param>
        public void Apply(ODataOrderHeader currentOrder, DdfDiscount discountData)
        {
            discount.Apply(currentOrder, discountData);
        }

        /// <summary>
        /// Calculate the order discount and apply it to the order.
        /// </summary>
        /// <param name="order">The OrderHeader including OrderProcess and OrderPricing models</param>
        /// <param name="discountData">The DdfDiscount model containg the discount data</param>
        public void Apply(OrderHeader order, DdfDiscount discountData)
        {
            discount.Apply(order, discountData);
        }

        //public static Expression<Func<OrderHeader, DdfDiscount, OrderHeader>> Apply()
        //{
        //    return (oh, d) => new OrderHeader
        //    {
        //        oh.OrderProcess.DiscountId = d.DiscountId;
        //        oh.OrderPricing.DiscountAmount = d.DiscountAmount;
        //        oh.OrderPricing.DealerTotal = 0;
        //    };
        //}
    }
}
