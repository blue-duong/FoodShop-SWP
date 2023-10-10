using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Category
    {
        public Category()
        {
            CategorGroups = new HashSet<CategorGroup>();
            CategoryDetailInfos = new HashSet<CategoryDetailInfo>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<CategorGroup> CategorGroups { get; set; }
        public virtual ICollection<CategoryDetailInfo> CategoryDetailInfos { get; set; }
    }
}
