using Coin.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Coin.Shared.Models
{
    /// <summary>
    /// This VM handles passing order data between client and server as well as translation between VM and EF Core models.
    /// </summary>
    public partial class ODataOrderHeader
    {
        [Key]
        public int OrderId { get; set; }
        public int JobId { get; set; }
        [Required]
        [Range(0.1, Double.MaxValue, ErrorMessage = "The field {0} must be greater than zero.")]
        public decimal DealerNetListTotal { get; set; }
        public decimal OrderTotal { get; set; }
        [Required]
        [Range(0.1, Double.MaxValue, ErrorMessage = "The field {0} must be greater than zero.")]
        public decimal DiscountAmount { get; set; }
        public decimal DiscountDollarAmount { get; set; }
        public string DiscountId { get; set; }

        //[System.Text.Json.Serialization.JsonPropertyName("Job")]
        //public JobsView Job { get; set; }

        //public ODataOrderHeader() { Job = new JobsView(); }

        //public ODataOrderHeader(OrderHeader order)
        //{
        //        OrderId = order.OrderId;
        //        JobId = order.JobId;
        //        Brand = order.Brand;
        //        Name = order.Name;
        //        OrderType = order.OrderType;
        //        ShopFloorNumber = order.ShopFloorNumber;
        //        OriginalShopOrderNumber = order.OriginalShopOrderNumber;
        //        CreatedByUserId = order.CreatedByUserId;
        //        CreatedDate = order.CreatedDate;
        //        ModifiedDate = order.ModifiedDate;
        //        LastModifiedByUserId = order.LastModifiedByUserId;
        //        ProductLine = order.ProductLine;
        //        Overlay = order.Overlay;
        //        CaseTotal = order.CaseTotal.Value;
        //        UseRealWoodEdgeTape = order.UseRealWoodEdgeTape;
        //        //DiscountId = order.DiscountId;
        //        //DiscountDescription = order.DiscountDescription;
        //}

        //    public OrderHeader MapToModel(OrderHeader order)
        //    {
        //        order.OrderId = OrderId;
        //        order.JobId = JobId;
        //        order.Brand = Brand;
        //        order.Name = Name;
        //        order.OrderType = OrderType;
        //        order.ShopFloorNumber = ShopFloorNumber;
        //        order.OriginalShopOrderNumber = OriginalShopOrderNumber;
        //        order.CreatedByUserId = CreatedByUserId;
        //        order.CreatedDate = CreatedDate;
        //        order.ModifiedDate = ModifiedDate;
        //        order.LastModifiedByUserId = LastModifiedByUserId;
        //        order.ProductLine = ProductLine;
        //        order.Overlay = Overlay;
        //        order.CaseTotal = CaseTotal;
        //        order.UseRealWoodEdgeTape = UseRealWoodEdgeTape;
        //        order.DiscountId = DiscountId;
        //        order.DiscountDescription = DiscountDescription;
        //        order.ExternalOrderStatus = order.ExternalOrderStatus;

        //        return order;
        //}


        //public static System.Linq.Expressions.Expression<Func<OrderHeader, ODataOrderHeader>> MapModelToView()
        //{
        //    return oh => new ODataOrderHeader()
        //    {
        //        //Type = oh.OrderType,
        //        OrderId = oh.OrderId,
        //        JobId = oh.JobId,
        //        Brand = oh.Brand,
        //        Name = oh.Name,
        //        DealerName = oh.Job.Location.LocationName,
        //        OrderStatus = oh.OrderProcess.OrderStatus,
        //        OriginalShopOrderNumber = oh.OriginalShopOrderNumber,
        //        //OrderType = oh.OrderType,
        //        ShopFloorNumber = oh.ShopFloorNumber,
        //        //CreatedByUserId = oh.CreatedByUserId,
        //        //CreatedDate = oh.CreatedDate,
        //        //ModifiedDate = oh.ModifiedDate,
        //        //LastModifiedByUserId = oh.LastModifiedByUserId,
        //        //Rowversion = oh.Rowversion,
        //        ProductLine = oh.ProductLine,
        //        Overlay = oh.Overlay,
        //        //Stgid = oh.Stgid,
        //        CaseTotal = oh.CaseTotal ?? 0,
        //        DealerNetListTotal = oh.OrderPricing.DealerNetListTotal.Value,
        //        OrderTotal = oh.OrderPricing.DealerTotal.Value,
        //        DoorStyle = oh.OrderConfiguration.WddoorStyle,
        //        Species = oh.OrderConfiguration.PcwoodSpecies,
        //        Finish = oh.OrderConfiguration.PcfinishColor,
        //        Sheen = oh.OrderConfiguration.Pcsheen,
        //        GlazeColor = oh.OrderConfiguration.PcglazeColor,
        //        ScheduledCompleteDate = oh.OrderProcessDates.ScheduledCompleteDate,
        //        EstimatedDeliveryDate = oh.OrderProcessDates.EstimatedDeliveryDate,
        //        SubmittedDate = oh.OrderProcessDates.SubmittedDate,
        //        ReceivedDate = oh.OrderProcessDates.ReceivedDate,
        //        Active = oh.Job.Active.Value,
        //        Facility = oh.OrderProcess.Plant,
        //        CheckQuality = oh.OrderProcess.IsBoldOnReport,
        //        IsFirstOrder = oh.OrderProcess.IsFirstOrder,
        //        IsCutManually = oh.OrderProcess.IsCutManually,
        //        Notes = oh.OrderConfiguration.Notes,
        //        DiscountId = oh.OrderProcess.DiscountId,
        //        //DiscountDescription = oh.DiscountDescription,
        //        DiscountAmount = oh.OrderPricing.DiscountAmount.Value,
        //        HasCharge = oh.Job.HasCharge.Value,
        //        AssociatedShopFloorNumbers = oh.Job.OrderHeader.Where(o => o.ShopFloorNumber != oh.ShopFloorNumber).Select(o => o.ShopFloorNumber),
        //        UseMatch = oh.OrderProcess.UseMatch,
        //        IsDisplay = oh.OrderProcess.IsDisplay,
        //        Processor = oh.OrderProcess.CorsiProcessor,
        //        Job = new JobsView()
        //        {
        //            JobId = oh.Job.JobId,
        //            LocationId = oh.Job.LocationId,
        //            JobName = oh.Job.JobName,
        //            SalesPerson = oh.Job.SalesPerson,
        //            CreditTerms = oh.Job.CreditTerms,
        //            CreditStatus = oh.Job.CreditStatus,
        //            Active = oh.Job.Active,
        //            CreatedByUserId = oh.Job.CreatedByUserId,
        //            ModifiedDate = oh.Job.ModifiedDate,
        //            OrderCount = oh.Job.OrderCount,
        //            Stgid = oh.Job.Stgid,
        //            CaseTotal = oh.Job.CaseTotal,
        //            JobNumber = oh.Job.JobNumber,
        //            JobType = oh.Job.JobType,
        //            JobStatus = oh.Job.JobStatus,
        //            HasCharge = oh.Job.HasCharge,
        //            JobPrice = oh.Job.JobPrice
        //        }
        //    };
        //}

    }
}
