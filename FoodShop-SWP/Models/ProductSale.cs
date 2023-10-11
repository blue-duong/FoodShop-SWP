using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class ProductSale
    {
        public int Id { get; set; }
        public int? SaleQuantity { get; set; }
        public int? Sold { get; set; }
        public int? ProductId { get; set; }
        public int? SaleEventId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual SaleEvent? SaleEvent { get; set; }
    }
}
