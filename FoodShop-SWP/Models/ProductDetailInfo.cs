using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class ProductDetailInfo
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int? CategoryDetailId { get; set; }
        public int? ProductId { get; set; }

        public virtual CategoryDetailInfo? CategoryDetail { get; set; }
        public virtual Product? Product { get; set; }
    }
}
