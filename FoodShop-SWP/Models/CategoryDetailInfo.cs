using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class CategoryDetailInfo
    {
        public CategoryDetailInfo()
        {
            ProductDetailInfos = new HashSet<ProductDetailInfo>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string? Name { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductDetailInfo> ProductDetailInfos { get; set; }
    }
}
