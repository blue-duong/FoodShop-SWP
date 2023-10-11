using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class ShopPlan
    {
        public ShopPlan()
        {
            ShopPackages = new HashSet<ShopPackage>();
        }

        public int Id { get; set; }
        public int? Duration { get; set; }
        public int? Price { get; set; }
        public string? Plan { get; set; }

        public virtual ICollection<ShopPackage> ShopPackages { get; set; }
    }
}
