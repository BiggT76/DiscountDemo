using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Coin.Shared.Discounts
{
    public class DiscountBase
    {
        public decimal Calculate(decimal orderTotal, decimal discountAmount)
        {
            return orderTotal - discountAmount.ApplyBankersRounding();
        }

        public void ThrowNegativeTotalException(string orderNumber)
        {
            throw new Exception($"Negative order total detected.  Please try again.");
        }
    }
}
