using Coin.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coin.Shared.Discounts
{
    public interface IDiscount
    {
        void Apply(ODataOrderHeader currentOrder, DdfDiscount discount);

        void Apply(OrderHeader order, DdfDiscount discount);
    }
}
