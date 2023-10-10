using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public bool? Feedbacked { get; set; }
        public int? Quantity { get; set; }
        public long? SellPrice { get; set; }
        public long? SoldPrice { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
