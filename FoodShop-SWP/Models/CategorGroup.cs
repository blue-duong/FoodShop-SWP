using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class CategorGroup
    {
        public CategorGroup()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
