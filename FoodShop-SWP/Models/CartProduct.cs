using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class CartProduct
    {
        public int? Quantity { get; set; }
        public int? CardId { get; set; }
        public int? ProductId { get; set; }
        public int Id { get; set; }

        public virtual Cart? Card { get; set; }
        public virtual Product? Product { get; set; }
    }
}
