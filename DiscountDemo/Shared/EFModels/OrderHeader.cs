﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coin.Shared.Models
{
    public partial class OrderHeader
    {
        public OrderHeader()
        {
            OrderPricing = new OrderPricing();
        }

        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("DiscountID")]
        [StringLength(50)]
        public string DiscountId { get; set; }

        [InverseProperty("Order")]
        public virtual OrderPricing OrderPricing { get; set; }
    }
}