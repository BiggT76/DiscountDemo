using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Coin.Shared.Models
{
    [Table("ddfDiscounts")]
    public partial class DdfDiscount
    {
        [Key]
        [Column("DiscountID")]
        public string DiscountId { get; set; }
        public string Brand { get; set; }
        public string DiscountDescription { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsPercentValue { get; set; }
    }
}
