using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class SaleEvent
    {
        public SaleEvent()
        {
            ProductSales = new HashSet<ProductSale>();
        }

        public int Id { get; set; }
        public DateTime? Endding { get; set; }
        public string? Name { get; set; }
        public int? Percent { get; set; }
        public DateTime? Start { get; set; }

        public virtual ICollection<ProductSale> ProductSales { get; set; }
    }
}
