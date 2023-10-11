using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Order
    {
        public Order()
        {
            Feedbacks = new HashSet<Feedback>();
            OrderDetails = new HashSet<OrderDetail>();
            Reports = new HashSet<Report>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? Description { get; set; }
        public string? ExpectedReceive { get; set; }
        public string? Payment { get; set; }
        public bool? Reported { get; set; }
        public long? SellPrice { get; set; }
        public long? ShippingFee { get; set; }
        public long? SoldPrice { get; set; }
        public bool? Special { get; set; }
        public string? Status { get; set; }
        public int? ReceiveInfoId { get; set; }
        public int? UserId { get; set; }

        public virtual ReceiveInfo? ReceiveInfo { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
