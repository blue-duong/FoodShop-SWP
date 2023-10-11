using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class ShopPackage
    {
        public int? Duration { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? StartTime { get; set; }
        public int? ShopPlanId { get; set; }
        public int Id { get; set; }

        public virtual ShopPlan? ShopPlan { get; set; }
    }
}
